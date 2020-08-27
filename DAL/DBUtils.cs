using System.Data.SqlClient;

namespace DAL
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"THANHPHUONG\SQLEXPRESS";
            string database = "BAN_HANG";

            return DBSQLserverUtils.GetDBConnection(datasource, database);
        }

    }
}
