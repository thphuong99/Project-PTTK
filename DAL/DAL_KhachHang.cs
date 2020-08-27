using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get { if (instance == null) instance = new DAL_KhachHang(); return instance; }
            private set { instance = value; }
        }

        public DAL_KhachHang() { }

        public bool insertKH(KhachHang kh)
        {
            string sql = "INSERT INTO KHACHHANG(TENKH, EMAIL, NGAYSINH, DIACHI) VALUES(@HOTEN,@EMAIL,@NGAYSINH,@DIACHI)";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                DateTime dDate = DateTime.Today;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@HOTEN", SqlDbType.VarChar).Value = kh.TENKH;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = kh.EMAIL;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime).Value = kh.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", SqlDbType.VarChar).Value = kh.DIACHI;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        
    }
}
