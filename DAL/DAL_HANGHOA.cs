using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_HANGHOA
    {
        public DataTable Get(int PNVQL)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from SanPham  where NVQL=" + PNVQL, conn);
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
        public DataTable GetNhapHang(int PNVQL)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from SanPham  where SLTonKho < SLToiThieu and NVQL=" + PNVQL, conn);
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
        public DataTable GetTraHang(int PNVQL)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from SanPham  where SoLuongTra>SoLuongTraToiDa and NVQL=" + PNVQL, conn);
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
        public bool InsertNhapHang(DonNhapHang DNH)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                SqlCommand com = new SqlCommand("insert into LICHSU_NHAP_NHACUNGCAP (MASP, NGAYNHAP, SOLUONG, NVPHUTRACH, XACNHAN, NCC,LYDONHAPHANG,QUANLY) values (@MASP,@NGAYNHAP,@SOLUONG,@NVPHUTRACH,@XACNHAN,@NCC,@LYDO,NULL)", conn);
                conn.Open();
                com.Parameters.AddWithValue("@MASP", DNH.Masp);
                com.Parameters.AddWithValue("@NGAYNHAP", DNH.NgayNhap);
                com.Parameters.AddWithValue("@SOLUONG", DNH.Soluong);
                com.Parameters.AddWithValue("@NVPHUTRACH", DNH.NVPhuTrach);
                com.Parameters.AddWithValue("@XACNHAN", DNH.XacNhan);
                com.Parameters.AddWithValue("@NCC", DNH.NCC);
                com.Parameters.AddWithValue("@LYDO", DNH.Lydo);
                com.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertTraHang(DonTraHang DTH)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                SqlCommand com = new SqlCommand("insert into LICHSU_TRA_NHACUNGCAP (MASP, NGAYTRA, SOLUONG, NVPHUTRACH, XACNHAN, NCC,LYDOTRA,QUANLY) values (@MASP,@NGAYTRA,@SOLUONG,@NVPHUTRACH,@XACNHAN,@NCC,@LYDOTRA,NULL)", conn);
                conn.Open();
                com.Parameters.AddWithValue("@MaSP", DTH.MaSp);
                com.Parameters.AddWithValue("@NGAYTRA", DTH.NgayTra);
                com.Parameters.AddWithValue("@SOLUONG", DTH.SoLuong);
                com.Parameters.AddWithValue("@NVPHUTRACH", DTH.NVPHUTRACH);
                com.Parameters.AddWithValue("@XACNHAN", DTH.XACNHAN);
                com.Parameters.AddWithValue("@NCC", DTH.NCC);
                com.Parameters.AddWithValue("@LYDOTRA", DTH.LydoTra);
                com.ExecuteNonQuery();
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
