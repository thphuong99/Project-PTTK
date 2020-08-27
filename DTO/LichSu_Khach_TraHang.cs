using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSu_Khach_TraHang
    {
        public LichSu_Khach_TraHang(int id, int makh, int masp, int soluong, string lydotra, DateTime ngaytra, int nvphutrach)
        {
            this.ID = id;
            this.MAKH = makh;
            this.MASP = masp;
            this.SOLUONG = soluong;
            this.LYDOTRA = lydotra;
            this.NGAYTRA = ngaytra;
            this.NVPHUTRACH = nvphutrach;
        }

        public LichSu_Khach_TraHang(DataRow row)
        {
            this.id = (int)row["id"];
            this.makh = (int)row["makh"];
            this.masp = (int)row["masp"];
            this.soluong = (int)row["soluong"];
            this.lydotra = row["lydotra"].ToString();
            this.ngaytra = (DateTime)row["ngaytra"];
            this.nvphutrach = (int)row["nvphutrach"];
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

        private string lydotra;
        public string LYDOTRA 
        {
            get { return lydotra; }
            set { lydotra = value; }
        }

        private DateTime ngaytra;
        public DateTime NGAYTRA
        {
            get { return ngaytra; }
            set { ngaytra = value; }
        }

        private int nvphutrach;
        public int NVPHUTRACH
        {
            get { return nvphutrach; }
            set { nvphutrach = value; }
        }
    }
}
