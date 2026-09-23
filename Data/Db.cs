using Microsoft.Data.SqlClient;

namespace GTSErpSystem.Data;

public sealed class Db
{
    private readonly string _cs;
    public Db(string cs)=>_cs=cs;
    public SqlConnection Open(){ var c=new SqlConnection(_cs); c.Open(); return c; }
}
