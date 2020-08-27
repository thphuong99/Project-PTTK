using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DONHANG
    {
        DAL_DonHang dal_donhang = new DAL_DonHang();
        public bool insertDH(DonHang dh)
        {
            return dal_donhang.insertDonHang(dh);
        }

        public bool deleteDH(int id)
        {
            return dal_donhang.delDonHang(id);
        }

    }
}
