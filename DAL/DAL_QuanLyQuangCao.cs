using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_QuanLyQuangCao
    {      
        
        public DataTable DocThongTinQC()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.TINDANG_QUANGCAO", conn);
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

        public DataTable DocThongTinHopDong()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.HOPDONG_QUANGCAO", conn);
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

        public DataTable DocKhachHang()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.KHACHHANG", conn);
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

        public DataTable DocTinNhanQC()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from dbo.TINNHAN_QUANGCAO", conn);
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

        public bool ThemHopDong(HopDong pHopDong)
        {
            string query = "INSERT INTO dbo.HOPDONG_QUANGCAO " +
                     "(TENDOITAC, NGAYLAP, VITRIDANGQC,THOIHAN) " +
                     "VALUES (@tendoitac,  @ngaylap , @vitridang, @thoihan) ";
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@tendoitac", SqlDbType.VarChar).Value = pHopDong.TenDoiTac;
                cmd.Parameters.Add("@ngaylap", SqlDbType.Date).Value = pHopDong.NgayLap;
                cmd.Parameters.Add("@vitridang", SqlDbType.Text).Value = pHopDong.ViTriDang;
                cmd.Parameters.Add("@thoihan", SqlDbType.Int).Value = pHopDong.ThoiHan;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool ThemTinNhanQC(TinNhanQC pTinNhanQC)
        {

            string query = "INSERT INTO dbo.TINNHAN_QUANGCAO " +
                     "(NOIDUNG, NGUOIGUI, NGAYGUI, NGUOINHAN) " +
                     "VALUES (@noidung,  @nguoigui, @ngaygui, @nguoinhan) ";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@noidung", SqlDbType.Text).Value = pTinNhanQC.NoiDung;
                cmd.Parameters.Add("@nguoigui", SqlDbType.Int).Value = pTinNhanQC.NguoiGui;
                cmd.Parameters.Add("@ngaygui", SqlDbType.Date).Value = pTinNhanQC.NgayGui;
                cmd.Parameters.Add("@nguoinhan", SqlDbType.Int).Value = pTinNhanQC.NguoiNhan;
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ThemTinQuangCao(TinQC pTinQC)
        {

            string query = "INSERT INTO dbo.TINDANG_QUANGCAO " +
                     "(NOIDUNG, NGUOIDANG, NGAYDANG, MAHOPDONG) " +
                     "VALUES (@noidung,  @nguoidang, @ngaydang, @mahopdong) ";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@noidung", SqlDbType.Text).Value = pTinQC.NoiDung;
                cmd.Parameters.Add("@nguoidang", SqlDbType.Int).Value = pTinQC.NguoiDang;
                cmd.Parameters.Add("@ngaydang", SqlDbType.Date).Value = pTinQC.NgayDang;
                cmd.Parameters.Add("@mahopdong", SqlDbType.Int).Value = pTinQC.MaHopDong;
                cmd.ExecuteNonQuery();
                conn.Close();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatTinQuangCao(TinQC pTinQC)
        {
            string query = "UPDATE dbo.TINDANG_QUANGCAO SET NOIDUNG = @noidung, NGAYSUA=@ngaysua WHERE ID=@id";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                DateTime dtDate = DateTime.Today;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pTinQC.ID;
                cmd.Parameters.Add("@noidung", SqlDbType.Text).Value = pTinQC.NoiDung;
                cmd.Parameters.Add("@ngaysua", SqlDbType.Date).Value = dtDate.Date;

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaTinQuangCao(TinQC pTinQC)
        {
            string query = "DELETE dbo.TINDANG_QUANGCAO WHERE ID=@id";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = pTinQC.ID;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
