using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_QuanLyQuangCao
    {
        DAL_QuanLyQuangCao dal_quanlyquangcao = new DAL_QuanLyQuangCao();
        public DataTable XemThongTinQC()
        {
            return dal_quanlyquangcao.DocThongTinQC();
        }

        public DataTable XemThongTinHopDong()
        {
            return dal_quanlyquangcao.DocThongTinHopDong();
        }

       
        public bool ThemTinQuangCao(TinQC pTinQC)
        {
            return dal_quanlyquangcao.ThemTinQuangCao(pTinQC);
        }

        public bool XoaTinQuangCao(TinQC pTinQC)
        {
            return dal_quanlyquangcao.XoaTinQuangCao(pTinQC);
        }

        public bool CapNhatTinQuangCao(TinQC pTinQC)
        {
            return dal_quanlyquangcao.CapNhatTinQuangCao(pTinQC);
        }
    }
}
