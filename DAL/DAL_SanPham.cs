using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_SanPham
    {
        private static DAL_SanPham instance;

        public static DAL_SanPham Instance
        {
            get { if (instance == null) instance = new DAL_SanPham(); return instance; }
            private set { instance = value; }
        }

        private DAL_SanPham() { }

        public List<SanPham> loadDanhSachSP()
        {
            List<SanPham> listSP = new List<SanPham>();

            string query = "SELECT *FROM SANPHAM";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sp = new SanPham(item);
                listSP.Add(sp);
            }

            return listSP;
        }

        public List<SanPham> searchSanPham(string tukhoa)
        {
            List<SanPham> listSP = new List<SanPham>();

            string query = string.Format("SELECT * FROM SANPHAM WHERE TENSP LIKE N'%{0}%'", tukhoa);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sp = new SanPham(item);
                listSP.Add(sp);
            }

            return listSP;
        }
    }
}
