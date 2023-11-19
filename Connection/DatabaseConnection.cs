using System.Data.SqlClient;
using System.Data;

public class DatabaseConnection
{
    private SqlConnection conn;

    public DatabaseConnection(string connectionString)
    {
        conn = new SqlConnection(connectionString);
    }

    public SqlConnection OpenConnection()
    {
        if (conn != null && conn.State == ConnectionState.Closed)
        {
            conn.Open();
        }
        return conn!;
    }

    public void CloseConnection()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }
}
