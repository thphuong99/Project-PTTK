using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang
    {
        private int madh;
        public int MADH
        {
            get { return madh; }
            set { madh = value; }
        }

        //private int mactdh;
        //public int MACTDH
        //{
        //    get { return mactdh; }  
        //    set { mactdh = value; }
        //}

        private int masp;
        public int MASP
        {
            get { return masp; }
            set { masp = value; }
        }

        private int soluong;
        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private float thanhtien;
        public float THANHTIEN
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        public ChiTietDonHang(int madh, int masp, int soluong, float thanhtien)
        {
            this.MADH = madh;
            //this.MACTDH = mactdh;
            this.masp = masp;
            this.soluong = soluong;
            this.THANHTIEN = thanhtien;
        }

        public ChiTietDonHang(DataRow row)
        {
            this.MADH = (int)row["madh"];
            this.MASP = (int)row["masp"];
            this.SOLUONG = (int)row["soluong"];
            this.THANHTIEN = (float)row["thanhtien"];
        }

        public ChiTietDonHang()
        {
        }
    }

}
