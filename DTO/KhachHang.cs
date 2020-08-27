using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public KhachHang(string tenkh, string email, string ngaysinh, string diachi)
        {
            this.TENKH = tenkh;
            this.EMAIL = email;
            this.NGAYSINH = ngaysinh;
            this.DIACHI = diachi;
        }

        public KhachHang(DataRow row)
        {
            this.tenkh = row["tenkh"].ToString();
            this.email = row["email"].ToString();
            this.ngaysinh = row["ngaysinh"].ToString();
            this.diachi = row["diachi"].ToString();

        }

        private int makh;
        public int MAKH
        {
            get { return makh; }
            set { makh = value; }
        }

        private string tenkh;
        public string TENKH
        {
            get { return tenkh; }
            set { tenkh = value; }
        }

        private string email;
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

        private string ngaysinh;
        public string NGAYSINH
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        private string diachi;
        public string DIACHI
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }
}
