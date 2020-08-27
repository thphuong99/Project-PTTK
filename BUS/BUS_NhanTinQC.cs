using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_NhanTinQC
    {
        DAL_QuanLyQuangCao dal_quanlyquangcao = new DAL_QuanLyQuangCao();
        public DataTable XemThongTinKhachHang()
        {
            return dal_quanlyquangcao.DocKhachHang();
        }
        public bool ThemTinNhanQC(TinNhanQC pTinNhanQC)
        {
            return dal_quanlyquangcao.ThemTinNhanQC(pTinNhanQC);
        }
        public DataTable XemTinNhan()
        {
            return dal_quanlyquangcao.DocTinNhanQC();
        }
    }
}
