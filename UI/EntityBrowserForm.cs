using Microsoft.Data.SqlClient;
using System.Data;

namespace GTSErpSystem.UI;

public sealed class EntityBrowserForm:Form
{
    readonly string _cs,_table; readonly DataGridView grid=new(){Dock=DockStyle.Fill,AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.DisplayedCells,ReadOnly=true,AllowUserToAddRows=false}; readonly TextBox search=new(){Width=300};
    public EntityBrowserForm(string cs,string table,string title){_cs=cs;_table=table;Text=title;Width=1100;Height=700;RightToLeft=RightToLeft.Yes;var top=new FlowLayoutPanel{Dock=DockStyle.Top,Height=45};top.Controls.Add(new Label{Text="بحث",AutoSize=true});top.Controls.Add(search);var b=new Button{Text="تحديث"};b.Click+=(s,e)=>LoadData();top.Controls.Add(b);Controls.Add(grid);Controls.Add(top);Load+=(_,_)=>LoadData();}
    void LoadData(){try{using var c=new SqlConnection(_cs);c.Open();var sql=$"SELECT TOP 500 * FROM dbo.[{_table}]";if(search.Text.Trim().Length>0){var cols=new List<string>();using var qc=new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME=@t",c);qc.Parameters.AddWithValue("@t",_table);using var rr=qc.ExecuteReader();while(rr.Read())cols.Add("["+rr.GetString(0).Replace("]","")+"] LIKE @s");rr.Close();if(cols.Count>0)sql+=" WHERE "+string.Join(" OR ",cols);};using var q=new SqlCommand(sql,c);if(search.Text.Trim().Length>0)q.Parameters.AddWithValue("@s","%"+search.Text.Trim()+"%");using var da=new SqlDataAdapter(q);var dt=new DataTable();da.Fill(dt);grid.DataSource=dt;}catch(Exception ex){MessageBox.Show(ex.Message,"خطأ");}}
}
