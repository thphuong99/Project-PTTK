using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class Hóa_Đơn : Form
    {
        public Hóa_Đơn()
        {
            InitializeComponent();
            BUS_CT_THANHTOAN busTT = new BUS_CT_THANHTOAN();
            CT_THANHTOAN ct = new CT_THANHTOAN();
            if (Thẻ.trangThai)
            {
                //cấp nhật đối tượng để lưu xuống dữ liệu
                hdSoTaiKhoan.Text = Thẻ.soTK;
                hdTenChuThe.Text = Thẻ.tenChuThe;
                hdTenNganHang.Text = Thẻ.tenNganHang;
                ct.NGANHANG = Thẻ.tenNganHang;
                ct.TENCHUTHE = Thẻ.tenChuThe;
                ct.HINHTHUC = "ONLINE";
                ct.SOTK = Thẻ.soTK;
                
            }
            else
            {
              
                hdPnThe.Visible = false;
                ct.HINHTHUC = "COD";
            }
            hdTenKhachHang.Text = ThanhToan.HoTen;
            hdSoDienThoai.Text = ThanhToan.sdt;
            hdDiaChiGiaoHang.Text = ThanhToan.DiaChi;
            hdTongCong.Text = busTT.GetTongTien().ToString();

            // lây thống chi chi tiết đơn hàng
            DataTable dt = busTT.layTTchiTiet();
            lvTTSP.Items.Clear();

            // hiển thị listview
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow drow = dt.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // định nghia các cột dữ liệu
                    ListViewItem lvi = new ListViewItem(drow["SOLUONG"].ToString());
                                     
                    lvi.SubItems.Add(drow["TENSP"].ToString());
                   
                    lvi.SubItems.Add(drow["DONGIA"].ToString());

                    lvi.SubItems.Add(drow["THANHTIEN"].ToString());

                    // thêm danh sách vào list view
                    lvTTSP.Items.Add(lvi);
                }
            }     
            // kiemr tra trạng thái đơn hàng
            if( busTT.layTrangThaiDonHang() == "1")
            {
                hdTrangThaiDonHang.Text = "Đã thanh toán.";
            }
            else
            {
                hdTrangThaiDonHang.Text = "Chưa thanh toán.";
            }
           
            ct.MAKH = busTT.GetIDKH(ThanhToan.Email);
            // Lưu chi tiết khách hàng thanh toán
            busTT.insert(ct);  
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thoát
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hóa_Đơn_Load(object sender, EventArgs e)
        {
           
        }
    }
}
