using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSu_ThanhToan_KhachHang
    {
        public LichSu_ThanhToan_KhachHang(int id, int makh, double tongtien, string hinhthuc, DateTime thoigian)
        {
            this.ID = id;
            this.MAKH = makh;
            this.TONGTIEN = tongtien;
            this.HINHTHUC = hinhthuc;
            this.THOIGIAN = thoigian;
        }

        private int id; 
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int makh;
        public int MAKH
        {
            get { return makh; }
            set { makh = value; }
        }

        private double tongtien;
        public double TONGTIEN
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private string hinhthuc;
        public string HINHTHUC
        {
            get { return hinhthuc; }
            set { hinhthuc = value; }
        }

        private DateTime thoigian;
        public DateTime THOIGIAN
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

    }
}
