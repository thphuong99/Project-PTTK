using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public SanPham(int masp, string tensp, double dongia, int sltonkho, int sltoithieu, int sltoida, int soluongtra, int soluongtratoida, int nvql)
        {
            this.MASP = masp;
            this.TENSP = tensp;
            this.DONGIA = dongia;
            this.SLTONKHO = sltonkho;
            //this.SLTOITHIEU = sltoithieu;
            //this.SLTOIDA = sltoida;
            //this.SOLUONGTRA = soluongtra;
            //this.SOLUONGTRATOIDA = soluongtratoida;
            //this.NVQL = nvql;
        }

        public SanPham(DataRow row)
        {
            this.MASP = (int)row["masp"];
            this.TENSP = row["tensp"].ToString();
            this.DONGIA = (double)row["dongia"];
            this.SLTONKHO = (int)row["sltonkho"];
            //this.SLTOITHIEU = (int)row["sltoithieu"];
            //this.SLTOIDA = (int)row["sltoida"];
            //this.SOLUONGTRA = (int)row["soluongtra"];
            //this.SOLUONGTRATOIDA = (int)row["soluongtratoida"];
            //this.NVQL = (int)row["nvql"];
        }

        private int masp;
        public int MASP
        {
            get { return masp; }
            set { masp = value; }
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

        private int sltonkho;
        public int SLTONKHO
        {
            get { return sltonkho; }
            set { sltonkho = value; }
        }
        //private int sltoithieu;
        //public int SLTOITHIEU
        //{
        //    get { return sltoithieu; }
        //    set { sltoithieu = value; }
        //}
        //private int sltoida;
        //public int SLTOIDA
        //{
        //    get { return sltoida; }
        //    set { sltoida = value; }
        //}

        //private int soluongtra;
        //public int SOLUONGTRA
        //{
        //    get { return soluongtra; }
        //    set { soluongtra = value; }
        //}

        //private int soluongtratoida;
        //public int SOLUONGTRATOIDA
        //{
        //    get { return soluongtratoida; }
        //    set { soluongtratoida = value; }
        //}

        //private int nvql;
        //public int NVQL
        //{
        //    get { return nvql; }
        //    set { nvql = value; }
        //}
    }
}
