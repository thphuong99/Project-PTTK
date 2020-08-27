using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class DanhGiaSP : Form
    {
        Home home = new Home();
        BUS_Comment bus_comment = new BUS_Comment();
        public DanhGiaSP()
        {
            InitializeComponent();
        }

        private void QuayVe_Click(object sender, EventArgs e)
        {            
            home.Show();
            this.Hide();
        }

        public void showAllSanPham()
        {
            DataTable dt = bus_comment.getSanPham();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DanhGiaSP_Load(object sender, EventArgs e)
        {
            showAllSanPham();
        }


        string TENSP,MASP;
        public string getTenSanPham()
        {
            TENSP = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            return TENSP;
        }

        public string getMaSanPham()
        {
            MASP = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            return MASP;
        }



        private void DanhGia_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new comment(this);
            f1.ShowDialog();
        }
    }
}
