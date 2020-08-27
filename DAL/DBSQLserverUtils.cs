using System.Data.SqlClient;

namespace DAL
{
    class DBSQLserverUtils
    {
        public static SqlConnection
            GetDBConnection(string datasource, string database)
        {

            //Data Source = DESKTOP - 5E9PQHK\SQLEXPRESS; Initial Catalog = BAN_HANG; Integrated Security = True
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                       + database + ";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
