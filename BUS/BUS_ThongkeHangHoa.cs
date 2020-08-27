using System;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public class  BUS_ThongkeHangHoa
    {
        DAL_HANGHOA Dal_hanghoa = new DAL_HANGHOA();

        public DataTable GET_HangHoa(int PNVQL)
        {
            return Dal_hanghoa.Get(PNVQL);
        }
        public bool lapdonnhaphang(int PNVQL)
        {
            DataTable Sanpham = Dal_hanghoa.GetNhapHang(PNVQL);
            foreach (DataRow row in Sanpham.Rows)
            {
                DonNhapHang dnh = new DonNhapHang();
                dnh.Masp = row.Field<int>("MASP");
                dnh.NCC = row.Field<int>("NCC");
                dnh.NVPhuTrach = PNVQL;
                dnh.Soluong = row.Field<int>("SLToiDa") - row.Field<int>("SLTonKho");
                DateTime NgayNhap = DateTime.Now;
                dnh.NgayNhap = NgayNhap.Date.ToString("MM/dd/yyyy");
                dnh.Lydo = "HET HANG";
                dnh.XacNhan = 0;
                if (!Dal_hanghoa.InsertNhapHang(dnh))
                    return false;
             }
            return true;
        }
        public bool lapdontrahang(int PNVQL)
        {
            DataTable Sanpham = Dal_hanghoa.GetTraHang(PNVQL);
            foreach (DataRow row in Sanpham.Rows)
            {
                DonTraHang dth = new DonTraHang();
                dth.MaSp = row.Field<int>("MASP");
                dth.NCC = row.Field<int>("NCC");
                dth.NVPHUTRACH = PNVQL;
                dth.SoLuong = row.Field<int>("SoLuongTraToiDa");
                DateTime Ngaytra = DateTime.Now;
                dth.NgayTra = Ngaytra.Date.ToString("MM/dd/yyyy");
                dth.LydoTra = "LOI DO NHA SAN XUAT";
                dth.XACNHAN = 0;
                if (!Dal_hanghoa.InsertTraHang(dth)) 
                    return false;
            }
            return true;
        }
    }
}
