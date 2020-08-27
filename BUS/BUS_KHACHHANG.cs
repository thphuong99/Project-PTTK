using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KHACHHANG
    {
        DAL_KhachHang dal_khachhang = new DAL_KhachHang();
        public bool insertKH(KhachHang kh)
        {
            return dal_khachhang.insertKH(kh);
        }

        
    }
}