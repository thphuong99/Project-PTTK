using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang
    {
        public DonHang(
           string ngaylap, 
            int tongsoluong, double tongtien, int trangthai)
        {
           
            this.NGAYLAP = ngaylap;
            this.TONGSOLUONG = tongsoluong;
            this.TONGTIEN = tongtien;
            this.TRANGTHAI = trangthai;
        }

        public DonHang(DataRow row)
        {
            this.madh = (int)row["madh"];
            this.ngaylap = row["ngaylap"].ToString();
            this.tongsoluong = (int)row["tongsoluong"];
            this.tongtien = (double)row["tongtien"];
            this.trangthai = (int)row["trangthai"];
        }

        public DonHang()
        {
        }

        private int madh;

        public int MADH
        {
            get { return madh; }
            set { madh = value; }
        }

        private string ngaylap;

        public string NGAYLAP
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }

        private int tongsoluong;

        public int TONGSOLUONG
        {
            get { return tongsoluong; }
            set { tongsoluong = value; }
        }

        private double tongtien;

        public double TONGTIEN
        {
            get { return tongtien; }
            set { tongtien = value; }
        }

        private int trangthai;

        public int TRANGTHAI
        {
            get { return trangthai; }
            set { trangthai = value; }
        }

    }
}
