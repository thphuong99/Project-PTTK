using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Thẻ : Form
    {
        public static string tenNganHang;
        public static string soTK;
        public static string tenChuThe;
        public static bool trangThai = false;
        
        public Thẻ()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(theTbTenNganHang.Text) || String.IsNullOrEmpty(theTbSoTK.Text) || String.IsNullOrEmpty(theTbTenChuThe.Text) || String.IsNullOrEmpty(theTbChiNhanh.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
            }
            else
            {
                tenNganHang = theTbTenNganHang.Text;
                soTK = theTbSoTK.Text;
                tenChuThe = theTbTenChuThe.Text;
                trangThai = true;
                Hóa_Đơn formHoaDon;
                formHoaDon = new Hóa_Đơn();
                formHoaDon.ShowDialog();
                this.Hide();
            }

        }

        private void theTbTenNganHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
