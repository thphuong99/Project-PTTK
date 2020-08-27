using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Comment
    {
        SqlDataAdapter da;
        public DataTable getSanPham()
        {
            string sqlquery = "SELECT * FROM SANPHAM";
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

        public DataTable getNguoiDung_Cam()
        {
            string sqlquery = "SELECT EMAIL FROM CAMNGUOIDUNG";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                da = new SqlDataAdapter(sqlquery, conn);
                conn.Open();
                DataTable NguoiDung_Cam = new DataTable();
                da.Fill(NguoiDung_Cam);
                conn.Close();
                return NguoiDung_Cam;
            }
            catch
            {
                return null;
            }
        }
        public bool InsertComment(Comment binhluan)
        {
            foreach (DataRow row in getNguoiDung_Cam().Rows)
            {
                if (binhluan._EMAIL == row["EMAIL"].ToString())
                return false;
            }
            string sql = "INSERT INTO BINHLUAN(HOTEN,EMAIL,DIACHI,NGAYBL,NOIDUNG,MASP,PHANLOAI) VALUES(@HOTEN,@EMAIL,@DIACHI,@NGAYBL,@NOIDUNG,@MASP,@PHANLOAI)";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                DateTime dDate = DateTime.Today;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@HOTEN", SqlDbType.VarChar).Value = binhluan._HOTEN;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = binhluan._EMAIL;
                cmd.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = binhluan._DIACHI;
                cmd.Parameters.Add("@NGAYBL", SqlDbType.DateTime).Value = dDate.Date;
                cmd.Parameters.Add("@NOIDUNG", SqlDbType.Text).Value = binhluan._NOIDUNG;
                cmd.Parameters.Add("@MASP", SqlDbType.Int).Value = Convert.ToInt32(binhluan._MASP);
                cmd.Parameters.Add("@PHANLOAI", SqlDbType.Int).Value = Convert.ToInt32(binhluan._PHANLOAI);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getComment(string MASP)
        {
            string sqlquery = "SELECT HOTEN,EMAIL,DIACHI,NGAYBL,NOIDUNG FROM BINHLUAN WHERE MASP='"+MASP+"' ";
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
    }
}
