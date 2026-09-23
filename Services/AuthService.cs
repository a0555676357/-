using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace GTSErpSystem.Services;

public static class AuthService
{
    public static bool Verify(string password, string storedHash)
    {
        if (string.IsNullOrWhiteSpace(storedHash)) return false;
        try { var parts=storedHash.Split('.',2); if(parts.Length!=2) return false; var salt=Convert.FromBase64String(parts[0]); var expected=Convert.FromBase64String(parts[1]); using var kdf=new Rfc2898DeriveBytes(password,salt,120000,HashAlgorithmName.SHA256); return CryptographicOperations.FixedTimeEquals(kdf.GetBytes(expected.Length),expected); } catch { return false; }
    }
    public static string Hash(string password)
    {
        var salt=RandomNumberGenerator.GetBytes(16); using var kdf=new Rfc2898DeriveBytes(password,salt,120000,HashAlgorithmName.SHA256); return Convert.ToBase64String(salt)+"."+Convert.ToBase64String(kdf.GetBytes(32));
    }
}
