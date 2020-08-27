using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL_QL_Comment
    {
        SqlDataAdapter da;
        public DataTable QL_getComment_Xau()
        {
            string sqlquery = "SELECT * FROM BINHLUAN WHERE PHANLOAI='1'";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                da = new SqlDataAdapter(sqlquery, conn);
                conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable QL_getComment_Tot()
        {
            string sqlquery = "SELECT * FROM BINHLUAN WHERE PHANLOAI='0'";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                da = new SqlDataAdapter(sqlquery, conn);
                conn.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool DeleteComment(string MABL)
        {
            string sqlquery = "DELETE BINHLUAN WHERE MABL=@MABL";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlquery, conn);
                cmd.Parameters.Add("@MABL", SqlDbType.Int).Value = Convert.ToInt32(MABL);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool InsertNguoiDung_Cam(string EMAIL)
        {
            string sql = "INSERT INTO CAMNGUOIDUNG(EMAIL) VALUES (@EMAIL)";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = EMAIL;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
