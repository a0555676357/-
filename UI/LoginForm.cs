using System.Data;
using Microsoft.Data.SqlClient;
using GTSErpSystem.Services;

namespace GTSErpSystem.UI;

public sealed class LoginForm:Form
{
    TextBox user=new(){Width=260}; TextBox pass=new(){Width=260,UseSystemPasswordChar=true}; Button login=new(){Text="دخول",Width=120}; Label msg=new(){AutoSize=true};
    readonly string _cs;
    public string UserName {get;private set;}=string.Empty;
    public LoginForm(string cs){_cs=cs; RightToLeft=RightToLeft.Yes; Text="تسجيل الدخول"; Width=430; Height=260; StartPosition=FormStartPosition.CenterScreen; var p=new TableLayoutPanel{Dock=DockStyle.Fill,Padding=new Padding(25),ColumnCount=2,RowCount=4}; p.Controls.Add(new Label{Text="اسم المستخدم",AutoSize=true},0,0);p.Controls.Add(user,1,0);p.Controls.Add(new Label{Text="كلمة المرور",AutoSize=true},0,1);p.Controls.Add(pass,1,1);p.Controls.Add(login,1,2);p.Controls.Add(msg,1,3);Controls.Add(p);login.Click+=Login;}
    void Login(object? s,EventArgs e){try{using var c=new SqlConnection(_cs);c.Open();using var q=new SqlCommand("SELECT TOP 1 Name,PassWord,IsActive FROM User_Login WHERE Name=@u",c);q.Parameters.AddWithValue("@u",user.Text.Trim());using var r=q.ExecuteReader();if(!r.Read()){msg.Text="بيانات الدخول غير موجودة في قاعدة البيانات.";return;}if(!Convert.ToBoolean(r[2])){msg.Text="المستخدم غير فعال.";return;}if(!AuthService.Verify(pass.Text,Convert.ToString(r[1])??"")){msg.Text="كلمة المرور غير صحيحة.";return;}UserName=Convert.ToString(r[0])??"";DialogResult=DialogResult.OK;Close();}catch(Exception ex){msg.Text="تعذر الاتصال بقاعدة البيانات: "+ex.Message;}}
}
