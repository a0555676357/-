using Microsoft.Data.SqlClient;
using GTSErpSystem.Services;
namespace GTSErpSystem.UI;
public sealed class FirstUserForm:Form
{
 readonly string _cs; readonly TextBox name=new(){Width=250}; readonly TextBox pass=new(){Width=250,UseSystemPasswordChar=true}; readonly TextBox confirm=new(){Width=250,UseSystemPasswordChar=true}; readonly Button save=new(){Text="إنشاء المستخدم الأول",Width=180}; readonly Label msg=new(){AutoSize=true};
 public FirstUserForm(string cs){_cs=cs;Text="تهيئة النظام — إنشاء أول مستخدم";Width=520;Height=300;RightToLeft=RightToLeft.Yes;StartPosition=FormStartPosition.CenterScreen;var p=new TableLayoutPanel{Dock=DockStyle.Fill,Padding=new Padding(25),ColumnCount=2,RowCount=5};p.Controls.Add(new Label{Text="اسم المستخدم",AutoSize=true},0,0);p.Controls.Add(name,1,0);p.Controls.Add(new Label{Text="كلمة المرور",AutoSize=true},0,1);p.Controls.Add(pass,1,1);p.Controls.Add(new Label{Text="تأكيد كلمة المرور",AutoSize=true},0,2);p.Controls.Add(confirm,1,2);p.Controls.Add(save,1,3);p.Controls.Add(msg,0,4);p.SetColumnSpan(msg,2);Controls.Add(p);save.Click+=Save;}
 void Save(object? s,EventArgs e){if(string.IsNullOrWhiteSpace(name.Text)||pass.Text.Length<8){msg.Text="أدخل اسم مستخدم وكلمة مرور من 8 أحرف على الأقل.";return;}if(pass.Text!=confirm.Text){msg.Text="تأكيد كلمة المرور غير مطابق.";return;}try{using var c=new SqlConnection(_cs);c.Open();using var q=new SqlCommand("INSERT INTO dbo.User_Login (Name,PassWord,IsActive) VALUES (@n,@p,1)",c);q.Parameters.AddWithValue("@n",name.Text.Trim());q.Parameters.AddWithValue("@p",AuthService.Hash(pass.Text));q.ExecuteNonQuery();DialogResult=DialogResult.OK;Close();}catch(Exception ex){msg.Text=ex.Message;}}
}
