using System.Data;
using Microsoft.Data.SqlClient;
using GTSErpSystem.Data;

namespace GTSErpSystem.UI;

/// <summary>عارض عام فعلي للجداول: تحميل، بحث، تصدير CSV، وإعادة تحميل.</summary>
public sealed class EntityBrowserForm : Form
{
    private readonly string _table;
    private readonly Db _db;
    private readonly DataGridView _grid = new() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
    private readonly TextBox _search = new() { Width = 260, PlaceholderText = "بحث..." };
    private readonly Label _count = new() { AutoSize = true, Padding = new Padding(8) };

    public EntityBrowserForm(string connectionString, string table, string title)
    {
        _table = table;
        _db = new Db(connectionString);
        Text = title;
        Width = 1100; Height = 700;
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        var toolbar = new FlowLayoutPanel { Dock = DockStyle.Top, Height = 45, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(6) };
        var refresh = new Button { Text = "تحديث", AutoSize = true };
        var export = new Button { Text = "تصدير CSV", AutoSize = true };
        refresh.Click += (_, _) => LoadData();
        export.Click += (_, _) => ExportCsv();
        _search.KeyDown += (_, e) => { if (e.KeyCode == Keys.Enter) LoadData(); };
        toolbar.Controls.Add(refresh); toolbar.Controls.Add(export); toolbar.Controls.Add(_search); toolbar.Controls.Add(_count);
        Controls.Add(_grid); Controls.Add(toolbar);
        Shown += (_, _) => LoadData();
    }

    private void LoadData()
    {
        try
        {
            var table = Db.Identifier(_table);
            var sql = $"SELECT TOP (500) * FROM dbo.{table}";
            var data = _db.Query(sql);
            if (!string.IsNullOrWhiteSpace(_search.Text))
            {
                var view = data.DefaultView;
                var text = _search.Text.Replace("'", "''");
                var filters = data.Columns.Cast<DataColumn>().Select(c => $"CONVERT([{c.ColumnName}], 'System.String') LIKE '%{text}%'");
                view.RowFilter = string.Join(" OR ", filters);
                _grid.DataSource = view;
                _count.Text = $"{view.Count} سجل";
            }
            else { _grid.DataSource = data; _count.Text = $"{data.Rows.Count} سجل"; }
        }
        catch (Exception ex)
        {
            _grid.DataSource = null;
            _count.Text = "فشل التحميل";
            MessageBox.Show($"تعذر قراءة الجدول [{_table}]\n{ex.Message}", "خطأ قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ExportCsv()
    {
        if (_grid.DataSource is not DataView view && _grid.DataSource is not DataTable) return;
        using var dialog = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"{_table}.csv" };
        if (dialog.ShowDialog(this) != DialogResult.OK) return;
        var data = _grid.DataSource is DataView dv ? dv.ToTable() : (DataTable)_grid.DataSource;
        using var writer = new StreamWriter(dialog.FileName, false, System.Text.Encoding.UTF8);
        writer.WriteLine(string.Join(",", data.Columns.Cast<DataColumn>().Select(c => Csv(c.ColumnName))));
        foreach (DataRow row in data.Rows)
            writer.WriteLine(string.Join(",", row.ItemArray.Select(x => Csv(Convert.ToString(x) ?? ""))));
        MessageBox.Show("تم التصدير بنجاح.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static string Csv(string value) => $"\"{value.Replace("\"", "\"\"")}\"";
}
