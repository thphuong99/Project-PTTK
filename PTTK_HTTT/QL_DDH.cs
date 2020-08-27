using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fQLDDH : Form
    {
        public fQLDDH()
        {
            InitializeComponent();
            loadDDH();
        }

        void loadDDH()
        {
            dtgv_ddh.DataSource = DAL_DonHang.Instance.loadDDH(); 


            dtgv_ddh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        List<DonHang> searchDH(string tukhoa)
        {
            List<DonHang> list = DAL_DonHang.Instance.searchDonHang(tukhoa);
            return list;
        }

        private void txbSearchDH_TextChanged(object sender, EventArgs e)
        {
            dtgv_ddh.DataSource = searchDH(txbSearchDH.Text);
        }

        private void dtgv_ddh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delDDH((int)dtgv_ddh.CurrentRow.Cells[0].Value);
            loadDDH();
        }

        void delDDH(int id)
        {
            if (DAL_DonHang.Instance.delDonHang(id))
            {
                MessageBox.Show("Xóa đơn đặt hàng thành công!!");
            }
            else
            {
                MessageBox.Show("Xóa đơn đặt hàng thất bại!!");
            }
        }

        private void fQLDDH_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
            this.Hide();
        }
    }
}
