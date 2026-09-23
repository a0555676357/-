using System.Reflection;
using System.Text.Json;

namespace GTSErpSystem.UI;

public sealed class MainForm : Form
{
    private readonly string _connectionString;
    private readonly string _user;
    private readonly TreeView _tree = new() { Dock = DockStyle.Right, Width = 320, HideSelection = false };
    private readonly StatusStrip _status = new();
    private readonly ToolStripStatusLabel _statusText = new("جاهز");
    private readonly List<CatalogItem> _catalog = new();

    public MainForm(string connectionString, string user)
    {
        _connectionString = connectionString;
        _user = user;
        Text = $"نظام الصقر المحاسبي — {_user}";
        IsMdiContainer = true;
        WindowState = FormWindowState.Maximized;
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;
        MainMenuStrip = BuildMainMenu();
        Controls.Add(_tree);
        _status.Items.Add(_statusText);
        Controls.Add(_status);
        _tree.AfterSelect += OpenSelected;
        BuildMenu();
    }

    private MenuStrip BuildMainMenu()
    {
        var menu = new MenuStrip();
        var window = new ToolStripMenuItem("النوافذ");
        window.DropDownItems.Add("إغلاق النافذة الحالية", null, (_, _) => ActiveMdiChild?.Close());
        window.DropDownItems.Add("إغلاق جميع النوافذ", null, (_, _) =>
        {
            foreach (var child in MdiChildren) child.Close();
        });
        window.DropDownItems.Add("تحديث القائمة", null, (_, _) => BuildMenu());
        menu.Items.Add(window);
        return menu;
    }

    private void BuildMenu()
    {
        _tree.Nodes.Clear();
        _catalog.Clear();
        var path = Path.Combine(AppContext.BaseDirectory, "UI", "form-catalog.json");
        try
        {
            if (File.Exists(path))
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                _catalog.AddRange(JsonSerializer.Deserialize<List<CatalogItem>>(File.ReadAllText(path), options) ?? new());
            }
            foreach (var group in _catalog.Where(x => !string.IsNullOrWhiteSpace(x.Module))
                         .GroupBy(x => x.Module, StringComparer.OrdinalIgnoreCase).OrderBy(x => x.Key))
            {
                var module = new TreeNode(group.Key);
                foreach (var item in group.OrderBy(x => x.Name))
                    module.Nodes.Add(new TreeNode(item.Name) { Tag = item });
                _tree.Nodes.Add(module);
                module.Expand();
            }
            _statusText.Text = $"تم تحميل {_catalog.Count} نافذة — المستخدم: {_user}";
        }
        catch (Exception ex) { ShowError("تعذر تحميل قائمة النوافذ", ex); }
    }

    private void OpenSelected(object? sender, TreeViewEventArgs e)
    {
        if (e.Node.Tag is not CatalogItem item) return;
        try
        {
            var form = CreateForm(item);
            if (form is null && !string.IsNullOrWhiteSpace(item.Entity))
                form = new EntityBrowserForm(_connectionString, item.Entity, item.Name);
            if (form is null)
            {
                MessageBox.Show($"النموذج {item.FullName} غير موجود في المصدر الحالي.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            form.MdiParent = this;
            form.RightToLeft = RightToLeft.Yes;
            form.RightToLeftLayout = true;
            form.Text = item.Name;
            form.Show();
            form.BringToFront();
            _statusText.Text = $"مفتوح: {item.Name}";
        }
        catch (Exception ex) { ShowError($"تعذر فتح {item.Name}", ex); }
    }

    private Form? CreateForm(CatalogItem item)
    {
        var type = Type.GetType(item.FullName, false) ?? Assembly.GetExecutingAssembly().GetType(item.FullName, false);
        if (type is null || !typeof(Form).IsAssignableFrom(type)) return null;
        var context = type.GetConstructor(new[] { typeof(string), typeof(string) });
        if (context is not null) return context.Invoke(new object[] { _connectionString, _user }) as Form;
        var connection = type.GetConstructor(new[] { typeof(string) });
        if (connection is not null) return connection.Invoke(new object[] { _connectionString }) as Form;
        return Activator.CreateInstance(type) as Form;
    }

    private void ShowError(string title, Exception exception)
    {
        _statusText.Text = title;
        MessageBox.Show($"{title}\n{exception.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private sealed record CatalogItem(string Name, string FullName, string Module, string BaseType, string? Entity);
}
