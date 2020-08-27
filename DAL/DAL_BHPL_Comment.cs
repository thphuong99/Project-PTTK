using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_BHPL_Comment
    {
        
        SqlDataAdapter da;
        public DataTable BH_getComment()
        {
            string sqlquery = "SELECT * FROM BINHLUAN";
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

        public bool BH_Updatecomment(Comment binhluan,string MABL)
        {
            string sql = "UPDATE BINHLUAN SET PHANLOAI=@PHANLOAI WHERE MABL=@MABL";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MABL", SqlDbType.Int).Value = Convert.ToInt32(MABL);
                cmd.Parameters.Add("@PHANLOAI", SqlDbType.Int).Value = Convert.ToInt32(binhluan._PHANLOAI);
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
