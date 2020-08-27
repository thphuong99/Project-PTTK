using DAL;
using System.Data;
using DTO;
namespace BUS
{
    public class BUS_CT_THANHTOAN
    {

        DAL_CT_THANHTOAN dt_tt = new DAL_CT_THANHTOAN();

        public int GetIDKH(string email)
        {   
            return dt_tt.getIDKH(email);
        }
        public int GetIDDH()
        {
            return dt_tt.getIDDH();
        }

        public int GetTongTien()
        {
            return dt_tt.layTongTien(GetIDDH());
        }
        public string layTrangThaiDonHang()
        {
            return dt_tt.layTrangThaiDonHang();
        }
        public  DataTable layTTchiTiet()
        {

            return dt_tt.layThongTinBill(GetIDDH());
        }

        public bool insert(CT_THANHTOAN  ct)
        {
            // gán thông tin cho Ct
            ct.TONGTIEN = dt_tt.layTongTien(GetIDDH());
            ct.MADH = dt_tt.getIDDH();

            return dt_tt.insert(ct);
        }
        public DataTable layTTDonHang()
        {
            return dt_tt.layTTDonHang();
        }
        public bool capNhatThanhToan(int madh)
        {
            return dt_tt.capNhatThanhToan(madh);
        }

    }
}
