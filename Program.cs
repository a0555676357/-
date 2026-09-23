using System.Text.Json;
using GTSErpSystem.UI;
using Microsoft.Data.SqlClient;

namespace GTSErpSystem;

internal static class Program
{
 [STAThread] static void Main(){ApplicationConfiguration.Initialize();var cs=LoadCs(); if (!HasUserTable(cs)) { using var setup=new FirstUserForm(cs); if(setup.ShowDialog()!=DialogResult.OK)return; } using var login=new LoginForm(cs);if(login.ShowDialog()!=DialogResult.OK)return;Application.Run(new MainForm(cs,login.UserName));}

 static bool HasUserTable(string cs){try{using var c=new SqlConnection(cs);c.Open();using var q=new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='User_Login'",c);if(Convert.ToInt32(q.ExecuteScalar())==0)return false;using var u=new SqlCommand("SELECT COUNT(*) FROM dbo.User_Login",c);return Convert.ToInt32(u.ExecuteScalar())>0;}catch{return false;}}
 static string LoadCs(){try{var o=JsonSerializer.Deserialize<Dictionary<string,Dictionary<string,string>>>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"appsettings.json")));return o?["ConnectionStrings"]["Default"]??throw new Exception();}catch{return "Server=localhost;Database=GTSErpSystem;Trusted_Connection=True;TrustServerCertificate=True;";}}
}

