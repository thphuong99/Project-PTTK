using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TT_DonDatHang
    {
        public TT_DonDatHang(int stt, string tensp, double dongia, int soluong, double thanhtien)
        {
            this.STT = stt;
            this.TENSP = tensp;
            this.DONGIA = dongia;
            this.SOLUONG = soluong;
            this.THANHTIEN = thanhtien;
        }

        public TT_DonDatHang(DataRow row)
        {
            this.STT = (int)row["stt"];
            this.TENSP = row["tensp"].ToString();
            this.DONGIA = (double)row["dongia"];
            this.SOLUONG = (int)row["soluong"];
            this.THANHTIEN = (double)row["thanhtien"];
        }

        private int stt;
        public int STT
        {
            get { return stt; }
            set { stt = value; }
        }

        private string tensp;

        public string TENSP
        {
            get { return tensp; }
            set { tensp = value; }
        }

        private double dongia;

        public double DONGIA
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private int soluong;

        public int SOLUONG
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private double thanhtien;

        public double THANHTIEN
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
    }
}
