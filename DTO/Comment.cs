using System;
using System.Data;

namespace DTO
{
    public class Comment
    {
        private int MABL;
        public int _MABL
        {
            get { return MABL; }
            set { MABL = value; }
        }

        private string HOTEN;
        public string _HOTEN
        {
            get { return HOTEN; }
            set { HOTEN = value; }
        }

        private string EMAIL;

        public string _EMAIL
        {
            get { return EMAIL; }
            set { EMAIL = value; }
        }

        private string DIACHI;
        public string _DIACHI
        {
            get { return DIACHI; }
            set { DIACHI = value; }
        }

        public DateTime NGAYBL;
        public DateTime _NGAYBL
        {
            get { return NGAYBL; }
            set { NGAYBL = value; }
        }
        private string NOIDUNG;
        public string _NOIDUNG
        {
            get { return NOIDUNG; }
            set { NOIDUNG = value; }
        }

        private int MASP;
        public int _MASP
        {
            get { return MASP; }
            set { MASP = value; }
        }

        private int PHANLOAI;
        public int _PHANLOAI
        {
            get { return PHANLOAI; }
            set { PHANLOAI = value; }
        }

        public Comment(string HOTEN, string EMAIL, string DIACHI, string NOIDUNG, int MASP,int PHANLOAI)
        {
            this._MABL = MABL;
            this._HOTEN = HOTEN;
            this._EMAIL = EMAIL;
            this._DIACHI = DIACHI;
            this._NOIDUNG = NOIDUNG;
            this._MASP = MASP;
            this._PHANLOAI = PHANLOAI;
        }
        public Comment(DataRow row)
        {
            this._MABL = (int)row["_MABL"];
            this._HOTEN = row["_HOTEN"].ToString();
            this._EMAIL = row["_EMAIL"].ToString();
            this._DIACHI = row["_DIACHI"].ToString();
            this._NOIDUNG = row["_NOIDUNG"].ToString();
            this._MASP = (int)row["_MASP"];
            this._PHANLOAI=(int)row["PHANLOAI"];
        }
    }
}
