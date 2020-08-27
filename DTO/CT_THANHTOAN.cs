namespace DTO
{
    public class CT_THANHTOAN
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value;  }
        }

        private int _MAKH;
        public int MAKH
        {
            get { return _MAKH; }
            set { _MAKH = value; }
        }

        private int _TONGTIEN;
        public int TONGTIEN
        {
            get { return _TONGTIEN; }
            set { _TONGTIEN = value; }
        }
       
        private string _HINHTHUC = "null";
        public string HINHTHUC
        {
            get { return _HINHTHUC; }
            set { _HINHTHUC = value; }
        }
        private string _THOIGIAN = "null";
        public string THOIGIAN
        {
            get { return _THOIGIAN; }
            set { _THOIGIAN = value; }
        }

        private int _MADH;
        public int MADH
        {
            get { return _MADH; }
            set { _MADH = value; }
        }

        private string _SOTK = "null";
        public string SOTK
        {
            get { return _SOTK; }
            set { _SOTK = value; }
        }
     
        private string _TENCHUTHE = "null";
        public string TENCHUTHE
        {
            get { return _TENCHUTHE; }
            set { _TENCHUTHE = value; }
        }
        private string _NGANHANG = "null";
        public string NGANHANG
        {
            get { return _NGANHANG; }
            set { _NGANHANG = value; }
        }
        //Khởi tạo đối tượng
        public CT_THANHTOAN(int id, int makh,int madh, int tongtien, string hinhthuc, string nganhang, string sotk, string tenchuthe, string thoigian )
        {
            this._ID = id;
            this._MAKH = makh;
            this._MADH = madh;
            this._SOTK = sotk;
            this._NGANHANG = nganhang;
            this._THOIGIAN = thoigian;
            this._TONGTIEN = tongtien;
            this._HINHTHUC = hinhthuc;
            this._TENCHUTHE = tenchuthe;
        }
        public CT_THANHTOAN()
        {
        
        }


    }
}
