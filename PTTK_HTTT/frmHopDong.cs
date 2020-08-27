using System;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmHopDong : Form
    {
        BUS_HopDong bus_hopdong =new BUS_HopDong();
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void btnTaoHopDong_Click(object sender, EventArgs e)
        {
            HopDong hopdong = new HopDong(txtTenDoiTac.Text, dpkNgayLap.Value.Date, txtViTriDang.Text,Int32.Parse(txtThoiHan.Text));
            if (bus_hopdong.ThemHopDong(hopdong))
            {
                              
                MessageBox.Show("Tạo thành công!");

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void frmHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
