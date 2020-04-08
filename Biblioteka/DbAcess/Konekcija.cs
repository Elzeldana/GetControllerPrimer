using System.Configuration;
using System.Data.SqlClient;

namespace WebApiExample.Core.DbHelper
{
    public class DbAccess
    {
        // create connection to the database from the cnnection string for shopDB from the config file
        public static SqlConnection GetOpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Recepti"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            return conn;
        }
    }
}
