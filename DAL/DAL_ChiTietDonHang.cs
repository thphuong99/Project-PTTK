using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChiTietDonHang
    {
        ChiTietDonHang ct = new ChiTietDonHang();

        private static DAL_ChiTietDonHang instance;

        public static DAL_ChiTietDonHang Instance
        {
            get { if (instance == null) instance = new DAL_ChiTietDonHang(); return instance; }
            private set { instance = value; }
        }

        public DAL_ChiTietDonHang() { }

        public void deleteDHHtheoID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.ChiTietDonHang where MADH = " + id);
        }

        public bool insertCTDDH(ChiTietDonHang ct)
        {


            string sql = "INSERT INTO dbo.CHITIETDONHANG(MADH, MASP, SOLUONG, THANHTIEN) VALUES(@MADH, @MASP, @SOLUONG, @THANHTIEN)";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MADH", SqlDbType.Int).Value = ct.MADH;
                cmd.Parameters.Add("@MASP", SqlDbType.Int).Value = ct.MASP;
                cmd.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = ct.SOLUONG;
                cmd.Parameters.Add("@THANHTIEN", SqlDbType.Float).Value = ct.THANHTIEN;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            conn.Close();


        }

    }
}
