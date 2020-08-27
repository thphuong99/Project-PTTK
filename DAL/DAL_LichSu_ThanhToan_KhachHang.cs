using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LichSu_ThanhToan_KhachHang
    {
        private static DAL_LichSu_ThanhToan_KhachHang instance;

        public static DAL_LichSu_ThanhToan_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_LichSu_ThanhToan_KhachHang(); return instance; }
            private set { instance = value; }
        }
    }
}
