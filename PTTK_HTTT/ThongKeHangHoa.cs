using System;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ThongKeHangHoa : Form
    {
        BUS_ThongkeHangHoa bus_tkhh = new BUS_ThongkeHangHoa();
        public ThongKeHangHoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaNhanVien.Text.ToString()))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông Báo");
            }
            else
                dataGridView1.DataSource = bus_tkhh.GET_HangHoa(Convert.ToInt32(MaNhanVien.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bus_tkhh.lapdonnhaphang(Convert.ToInt32(MaNhanVien.Text)))
            {
                MessageBox.Show("Lập đơn hàng thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Lập đơn hàng thất bại", "Thông Báo");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus_tkhh.lapdontrahang(Convert.ToInt32(MaNhanVien.Text)))
            {
                MessageBox.Show("Lập đơn hàng thành công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Lập đơn hàng thất bại", "Thông Báo");
            }
        }

        private void ThongKeHangHoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
