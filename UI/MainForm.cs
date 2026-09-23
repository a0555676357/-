using System.Text.Json;
using Microsoft.Data.SqlClient;

namespace GTSErpSystem.UI;

public sealed class MainForm:Form
{
 readonly string _cs; readonly string _user; readonly TreeView tree=new(){Dock=DockStyle.Left,Width=310}; readonly Panel host=new(){Dock=DockStyle.Fill}; List<CatalogItem> catalog=new();
 public MainForm(string cs,string user){_cs=cs;_user=user;Text="GTSErpSystem — نظام ERP";WindowState=FormWindowState.Maximized;RightToLeft=RightToLeft.Yes;Controls.Add(host);Controls.Add(tree);tree.AfterSelect+=Open;Load+=(_,_)=>BuildMenu();}
 void BuildMenu(){try{var path=Path.Combine(AppContext.BaseDirectory,"UI","form-catalog.json");catalog=JsonSerializer.Deserialize<List<CatalogItem>>(File.ReadAllText(path))??new();}catch{}var root=new TreeNode("النظام");foreach(var g in catalog.GroupBy(x=>string.IsNullOrWhiteSpace(x.module)?"Core":x.module).OrderBy(x=>x.Key)){var n=new TreeNode(g.Key);foreach(var x in g.OrderBy(z=>z.name))n.Nodes.Add(new TreeNode(x.name){Tag=x});root.Nodes.Add(n);}tree.Nodes.Clear();tree.Nodes.Add(root);root.Expand();}
 void Open(object? s,TreeViewEventArgs e){if(e.Node.Tag is not CatalogItem x)return;if(string.IsNullOrWhiteSpace(x.entity)){host.Controls.Clear();host.Controls.Add(new Label{Text=x.fullName+"\r\n\r\nهذه الشاشة مسجلة من التحليل الأصلي، ولا يوجد لها كيان قاعدة بيانات مباشر في بيانات الفحص.",Dock=DockStyle.Fill,TextAlign=ContentAlignment.MiddleCenter});return;}host.Controls.Clear();host.Controls.Add(new EntityBrowserForm(_cs,x.entity,x.name){TopLevel=false,FormBorderStyle=FormBorderStyle.None,Dock=DockStyle.Fill});((EntityBrowserForm)host.Controls[0]).Show();}
 record CatalogItem(string name,string fullName,string module,string baseType,string? entity);
}
