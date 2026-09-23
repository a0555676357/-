using System.Reflection;
using System.Text.Json;

namespace GTSErpSystem.UI;

/// <summary>
/// نافذة التنقل الرئيسية للنظام.
/// تعرض النوافذ مرتبة حسب الوحدة، وتحاول فتح النموذج الفعلي أولًا،
/// ثم تستخدم EntityBrowserForm عندما يكون للنموذج كيان قاعدة بيانات.
/// </summary>
public sealed class MainForm : Form
{
    private readonly string _connectionString;
    private readonly string _user;
    private readonly TreeView _tree = new()
    {
        Dock = DockStyle.Right,
        Width = 320,
        HideSelection = false,
        RightToLeft = RightToLeft.Yes
    };
    private readonly Panel _content = new() { Dock = DockStyle.Fill };
    private readonly Label _status = new()
    {
        Dock = DockStyle.Bottom,
        Height = 30,
        TextAlign = ContentAlignment.MiddleRight,
        Padding = new Padding(8)
    };
    private readonly List<CatalogItem> _catalog = new();

    public MainForm(string connectionString, string user)
    {
        _connectionString = connectionString;
        _user = user;

        Text = $"نظام الصقر المحاسبي — {_user}";
        WindowState = FormWindowState.Maximized;
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        StartPosition = FormStartPosition.CenterScreen;

        Controls.Add(_content);
        Controls.Add(_tree);
        Controls.Add(_status);
        _tree.AfterSelect += OpenSelected;

        BuildMenu();
    }

    private void BuildMenu()
    {
        _tree.Nodes.Clear();
        _catalog.Clear();

        try
        {
            var path = Path.Combine(AppContext.BaseDirectory, "UI", "form-catalog.json");
            if (File.Exists(path))
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var items = JsonSerializer.Deserialize<List<CatalogItem>>(File.ReadAllText(path), options);
                if (items is not null) _catalog.AddRange(items);
            }
        }
        catch (Exception ex)
        {
            _status.Text = $"تعذر تحميل قائمة النوافذ: {ex.Message}";
        }

        foreach (var group in _catalog
                     .Where(x => !string.IsNullOrWhiteSpace(x.Module))
                     .GroupBy(x => x.Module, StringComparer.OrdinalIgnoreCase)
                     .OrderBy(x => x.Key))
        {
            var moduleNode = new TreeNode(group.Key) { Name = group.Key };
            foreach (var item in group.OrderBy(x => x.Name))
                moduleNode.Nodes.Add(new TreeNode(item.Name) { Tag = item });
            _tree.Nodes.Add(moduleNode);
            moduleNode.Expand();
        }

        if (_tree.Nodes.Count > 0)
            _tree.SelectedNode = _tree.Nodes[0].FirstNode;
    }

    private void OpenSelected(object? sender, TreeViewEventArgs e)
    {
        if (e.Node.Tag is not CatalogItem item) return;

        try
        {
            var form = CreateForm(item);
            if (form is not null)
            {
                ShowChild(form, item.Name);
                return;
            }

            if (!string.IsNullOrWhiteSpace(item.Entity))
            {
                ShowChild(new EntityBrowserForm(_connectionString, item.Entity, item.Name), item.Name);
                return;
            }

            ShowMessage($"النموذج {item.FullName} غير موجود في النسخة الحالية.", item.Name);
        }
        catch (Exception ex)
        {
            ShowMessage($"تعذر فتح {item.Name}: {ex.Message}", "خطأ");
        }
    }

    private Form? CreateForm(CatalogItem item)
    {
        var type = Type.GetType(item.FullName, throwOnError: false)
                   ?? Assembly.GetExecutingAssembly().GetType(item.FullName, throwOnError: false);
        if (type is null || !typeof(Form).IsAssignableFrom(type)) return null;

        var withContext = type.GetConstructor(new[] { typeof(string), typeof(string) });
        if (withContext is not null)
            return (Form?)withContext.Invoke(new object[] { _connectionString, _user });

        var withConnection = type.GetConstructor(new[] { typeof(string) });
        if (withConnection is not null)
            return (Form?)withConnection.Invoke(new object[] { _connectionString });

        return Activator.CreateInstance(type) as Form;
    }

    private void ShowChild(Form child, string title)
    {
        child.StartPosition = FormStartPosition.CenterParent;
        child.RightToLeft = RightToLeft.Yes;
        child.RightToLeftLayout = true;
        child.Text = title;
        child.Show(this);
        _status.Text = $"مفتوح: {title}";
    }

    private void ShowMessage(string message, string title)
    {
        _content.Controls.Clear();
        _content.Controls.Add(new Label
        {
            Dock = DockStyle.Fill,
            Text = message,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font(Font.FontFamily, 14),
            RightToLeft = RightToLeft.Yes
        });
        _status.Text = title;
    }

    private sealed record CatalogItem(
        string Name,
        string FullName,
        string Module,
        string BaseType,
        string? Entity);
}
