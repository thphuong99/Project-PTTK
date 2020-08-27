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
    public class DAL_DonHang
    {
        private static DAL_DonHang instance;

        public static DAL_DonHang Instance
        {
            get { if (instance == null) instance = new DAL_DonHang(); return instance; }
            private set { instance = value; }
        }

        public DAL_DonHang() { }

        public List<DonHang> loadDDH()
        {
            List<DonHang> listDH = new List<DonHang>();

            string query = "SELECT *FROM DONHANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DonHang dh = new DonHang(item);
                listDH.Add(dh);
            }

            return listDH;
        }

        public List<DonHang> searchDonHang(string tukhoa)
        {
            List<DonHang> listSP = new List<DonHang>();

            string query = string.Format("SELECT * FROM DONHANG WHERE MADH LIKE N'%{0}%'", tukhoa);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DonHang sp = new DonHang(item);
                listSP.Add(sp);
            }

            return listSP;
        }
        public int getIDDH()
        {
            int iddh = 0;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                // Tạo một đối tượng Command để gọi hàm Get_Emp_No.
                SqlCommand cmd = new SqlCommand("Get_ID_DH", conn);

                // Kiểu của Command là StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;



                // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);

                //  
                resultParam.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters.Add(resultParam);

                // Gọi hàm.
                cmd.ExecuteNonQuery();


                if (resultParam.Value != DBNull.Value)
                {
                    iddh = (int)resultParam.Value;
                }



            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return iddh;
        }
        public bool insertDonHang(DonHang dh)
        {
            

            string sql = "INSERT INTO dbo.DONHANG(NGAYLAP, TONGSOLUONG, TONGTIEN, TRANGTHAI) VALUES(@NGAYLAP, @TONGSOLUONG, @TONGTIEN, @TRANGTHAI)";
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                DateTime dDate = DateTime.Today;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@NGAYLAP", SqlDbType.VarChar).Value = dh.NGAYLAP;
                cmd.Parameters.Add("@TONGSOLUONG", SqlDbType.Int).Value = dh.TONGSOLUONG;
                cmd.Parameters.Add("@TONGTIEN", SqlDbType.Float).Value = dh.TONGTIEN;
                cmd.Parameters.Add("@TRANGTHAI", SqlDbType.VarChar).Value = dh.TRANGTHAI;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool delDonHang(int id)
        {
            DAL_ChiTietDonHang.Instance.deleteDHHtheoID(id);

            string query = string.Format("Delete DONHANG where MADH = " + id);

            int result = DataProvider.Instance.executeNonQuery(query);

            return result > 0;
        }
    }
}
