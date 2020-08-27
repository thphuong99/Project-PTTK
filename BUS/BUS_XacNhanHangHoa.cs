using DAL;
using System.Data;

namespace BUS
{
    public class BUS_XacNhanHangHoa
    {
        DAL_XacNhanHangHoa dal_xnhh = new DAL_XacNhanHangHoa();
        public DataTable GetDonNhapHang(int MaQuanLy)
        {
            return dal_xnhh.GetDonNhapHang(MaQuanLy);
        }
        public bool UpdateXacNhanNhap(int MaDonNhapHang,int XacNhan,int MaQuanLy)
        {
            return dal_xnhh.UpdateXacNhanNhap(MaDonNhapHang,XacNhan,MaQuanLy);
        }
        public DataTable GetDonTraHang(int MaQuanLy)
        {
            return dal_xnhh.GetDonTraHang(MaQuanLy);
        }
        public bool UpdateXacNhanTra(int MaDonTraHang,int XacNhan,int MaQuanLy)
        {
            return dal_xnhh.UpdateXacNhanTra(MaDonTraHang, XacNhan,MaQuanLy);
        }
    }
}
