using System;
using System.Windows.Forms;

namespace GUI
{

    public partial class ThanhToan : Form
    {
   
        public static string HoTen;
        public static string DiaChi;
        public static string Email;
        public static string sdt;
       
        
        
        public ThanhToan()
        {
            InitializeComponent();
            checkBoxTienMat.Checked = true;
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gán giá trị puclic static

            HoTen = ttHoTen.Text;
            DiaChi = ttDiaChi.Text;
            Email = ttEmail.Text;
            sdt = ttSDT.Text;
            // kiểm tra điều kiện thanh toán
            if (checkBoxThe.Checked == true)
            {

                Thẻ the = new Thẻ();
                
                the.Show();
                the.Activate();
                this.Hide();

            }
            else
            {
                
                Hóa_Đơn hoaDon = new Hóa_Đơn();
                this.Hide();
                hoaDon.Show();

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxThe.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxTienMat.Checked = false;
     
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
