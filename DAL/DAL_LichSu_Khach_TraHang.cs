using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LichSu_Khach_TraHang
    {
        private static DAL_LichSu_Khach_TraHang instance;

        public static DAL_LichSu_Khach_TraHang Instance
        {
            get { if (instance == null) instance = new DAL_LichSu_Khach_TraHang(); return instance; }
            private set { instance = value; }
        }

        private DAL_LichSu_Khach_TraHang() { }

        public List<LichSu_Khach_TraHang> loadDTH()
        {
            List<LichSu_Khach_TraHang> listDTH = new List<LichSu_Khach_TraHang>();

            string query = "SELECT *FROM LichSu_Khach_TraHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LichSu_Khach_TraHang dth = new LichSu_Khach_TraHang(item);
                listDTH.Add(dth);
            }

            return listDTH;
        }

        public List<LichSu_Khach_TraHang> searchDTH(string tukhoa)
        {
            List<LichSu_Khach_TraHang> listDTH = new List<LichSu_Khach_TraHang>();

            string query = string.Format("SELECT * FROM LichSu_Khach_TraHang WHERE ID LIKE N'%{0}%'", tukhoa);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LichSu_Khach_TraHang dth = new LichSu_Khach_TraHang(item);
                listDTH.Add(dth);
            }

            return listDTH;
        }

        public List<ChiTietDonHang> loadTTDDH()
        {
            List<ChiTietDonHang> list = new List<ChiTietDonHang>();

            //list.Add();

            return list;
        }

        public bool insertDTH(int makh, int masp, int soluong, string lydotra, DateTime ngaytra, int nvphutrach)
        {
            string query = string.Format("INSERT INTO dbo.LICHSU_KHACH_TRAHANG(MAKH, MASP, SOLUONG, LYDOTRA, NGAYTRA, NVPHUTRACH) VALUES N('{0}', {1}, {2}, {3}, {4}, {5})", makh, masp, soluong, lydotra, ngaytra, nvphutrach);

            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }

        public bool delDTH(int id)
        {
            string query = string.Format("Delete LICHSU_KHACH_TRAHANG where ID = " + id);

            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
    }
}
