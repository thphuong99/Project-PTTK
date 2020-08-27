using DTO;
using DAL;

namespace BUS
{
    public class BUS_HopDong
    {
        DAL_QuanLyQuangCao dal_quanlyquangcao = new DAL_QuanLyQuangCao();
        public bool ThemHopDong(HopDong pHopDong)
        {
            return dal_quanlyquangcao.ThemHopDong(pHopDong);
        }
    }
}
