using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_XacNhanHangHoa
    {
        public DataTable GetDonNhapHang(int MaQuanLy)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select L.ID,L.SOLUONG,L.NVPHUTRACH,L.NGAYNHAP,L.LyDoNhapHang,C.TenNCC,S.TenSP from LICHSU_NHAP_NHACUNGCAP L join NHANVIEN N on L.NVPHUTRACH=N.MANV join SANPHAM s ON s.Masp=L.MASP join Nhacungcap C on C.MANCC=L.NCC where L.XACNHAN=0 AND N.NVQL=" + MaQuanLy, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetDonTraHang(int MaQuanLy)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select T.ID,T.SOLUONG,T.NVPHUTRACH,T.NGAYTRA,T.LyDoTra,C.TenNCC,S.TenSP from LICHSU_TRA_NHACUNGCAP T join NHANVIEN N on T.NVPHUTRACH=N.MANV join SANPHAM s ON s.Masp=T.MASP join Nhacungcap C on C.MANCC=T.NCC where T.XACNHAN=0 AND N.NVQL=" + MaQuanLy, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool UpdateXacNhanNhap(int MaDonNhapHang,int XacNhan,int MaQuanLy)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlCommand com = new SqlCommand("update LICHSU_NHAP_NHACUNGCAP set XACNHAN=@XACNHAN,QUANLY=@QUANLY  WHERE ID=@ID", conn);
                com.Parameters.AddWithValue("@ID", MaDonNhapHang);
                com.Parameters.AddWithValue("@XACNHAN", XacNhan);
                com.Parameters.AddWithValue("@QUANLY", MaQuanLy);
                com.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateXacNhanTra(int MaDonTraHang, int XacNhan,int MaQuanLy)
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlCommand com = new SqlCommand("update LICHSU_TRA_NHACUNGCAP set XACNHAN=@XACNHAN,QUANLY=@QUANLY  WHERE ID=@ID", conn);
                com.Parameters.AddWithValue("@ID", MaDonTraHang);
                com.Parameters.AddWithValue("@XACNHAN", XacNhan);
                com.Parameters.AddWithValue("@QUANLY", MaQuanLy);
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
