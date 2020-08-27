using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_CT_THANHTOAN : DBUtils
    {

        public int getIDKH(string email)
        {
            int idKh = 0;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                // Tạo một đối tượng Command để gọi hàm Get_Emp_No.
                SqlCommand cmd = new SqlCommand("Get_ID_KH", conn);

                // Kiểu của Command là StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số @email và gán giá trị email cho nó.
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);

                //  
                resultParam.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters.Add(resultParam);

                // Gọi hàm.
                cmd.ExecuteNonQuery();


                if (resultParam.Value != DBNull.Value)
                {
                    idKh = (int)resultParam.Value;
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
            return idKh;
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
        public DataTable layThongTinBill(int mahd)
        {
            try

            {

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();

                string sql = "Select * from dbo.CHITIETDONHANG, dbo.SANPHAM where dbo.CHITIETDONHANG.MASP = dbo.SANPHAM.MASP and MADH = " + mahd;
                
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }
        public int layTongTien(int mahd)
        {
            int iddh = 0;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                // Tạo một đối tượng Command để gọi hàm Get_Emp_No.
                SqlCommand cmd = new SqlCommand("Get_TONG_SP", conn);

                // Kiểu của Command là StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số @email và gán giá trị email cho nó.
                cmd.Parameters.Add("@madh", SqlDbType.Int).Value = mahd;

                // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Int);
                //nhận kết quả trả về từ câu lệnh truy vấn
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

        public string layTrangThaiDonHang()
        {
            string iddh = "";
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                // Tạo một đối tượng Command để gọi hàm Get_Emp_No.
                SqlCommand cmd = new SqlCommand("GET_STATUS_BILL", conn);
                // Kiểu của Command là StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;
                // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);

                resultParam.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(resultParam);
                 // Gọi hàm.
                cmd.ExecuteNonQuery();
                if (resultParam.Value != DBNull.Value)
                {
                    iddh = (string)resultParam.Value;
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
        public bool insert(CT_THANHTOAN TT)
        {

            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                TT.THOIGIAN = DateTime.Now.ToString("MM-dd-yyyy");
                // Câu lệnh Insert.
                string sql = "Insert into LICHSU_THANHTOAN_KHACHHANG ( MAKH , TONGTIEN , HINHTHUC , THOIGIAN , SOTK , NGANHANG , TENCHUTHE , MADH ) "
              + " values ( " + TT.MAKH + " , " + TT.TONGTIEN + " , '" + TT.HINHTHUC + "' , '" + TT.THOIGIAN + "' , '" + TT.SOTK + "' , '" + TT.NGANHANG + "' , '" + TT.TENCHUTHE + "' , " + TT.MADH + " );";
                // Câu lệnh sql.
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;
                // Thực thi Command (Dùng cho delete, insert, update).
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
            return true;
        }

        public DataTable layTTDonHang()
        {
            try
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                // câu lệnh truy vấn
                string sql = "Select * from dbo.DONHANG where TRANGTHAI = 0";
                //tạo bảng dữ liệu
                DataTable dt = new DataTable();
                // thực thi câu lệnh
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //gán dữ liệu
                da.Fill(dt);
                // đóng kết nối
                conn.Close();
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public bool capNhatThanhToan(int madh)
        {

            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            try
            {
                //câu lệnh sql
                string sql = "update DONHANG set TRANGTHAI = 1 WHERE  MADH = " + madh;
                
                // khái báo cmd
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // gọi thưc thi truy vấn
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }


            
        }
    }
}
