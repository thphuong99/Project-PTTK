using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }




        private void đÁNHGIÁToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhGiaSP a1 = new DanhGiaSP();
            this.Hide();
            a1.Show();
        }

        private void qUẢNLÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
            this.Hide();
            
        }

        private void sẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachSP dssp = new DanhSachSP();
            dssp.Show();
            this.Hide();
        }
    }
}
