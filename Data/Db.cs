using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace GTSErpSystem.Data;

/// <summary>وصول موحد وآمن إلى SQL Server مع استعلامات معاملات.</summary>
public sealed class Db
{
    private static readonly Regex SafeIdentifier = new("^[A-Za-z_][A-Za-z0-9_]*$", RegexOptions.Compiled);
    private readonly string _connectionString;

    public Db(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("سلسلة الاتصال مطلوبة.", nameof(connectionString));
        _connectionString = connectionString;
    }

    public SqlConnection Open()
    {
        var connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection;
    }

    public static string Identifier(string value)
    {
        if (!SafeIdentifier.IsMatch(value))
            throw new ArgumentException("اسم قاعدة البيانات غير صالح.", nameof(value));
        return $"[{value}]";
    }

    public DataTable Query(string sql, params SqlParameter[] parameters)
    {
        using var connection = Open();
        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);
        using var adapter = new SqlDataAdapter(command);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }
}
