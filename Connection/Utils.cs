using System.Data.SqlClient;


public class Utils
{
    private static string connectionString = "Data Source=localhost;Initial Catalog=QUANLYBANHANG; Integrated Security=true";
    public static string ConnectionString
    {
        get { return connectionString; }
        set { connectionString = value; }
    }
    private static bool IsServerConnected(string connectionString)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
