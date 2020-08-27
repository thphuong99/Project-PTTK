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
    public partial class QL_DDH : Form
    {
        public QL_DDH()
        {
            InitializeComponent();
            loadDTH();
        }

        void loadDTH()
        {
            dtgvDTH.DataSource = DAL_LichSu_Khach_TraHang.Instance.loadDTH();


            dtgvDTH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dtgvDTH.DataSource = searchDTH(textBox1.Text);
        }

        List<LichSu_Khach_TraHang> searchDTH(string tukhoa)
        {
            List<LichSu_Khach_TraHang> list = DAL_LichSu_Khach_TraHang.Instance.searchDTH(tukhoa);
            return list;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            delDDH((int)dtgvDTH.CurrentRow.Cells[0].Value);
            loadDTH();
        }

        void delDDH(int id)
        {
            if (DAL_LichSu_Khach_TraHang.Instance.delDTH(id))
            {
                MessageBox.Show("Xóa đơn trả hàng thành công!!");
            }
            else
            {
                MessageBox.Show("Xóa đơn trả hàng thất bại!!");
            }
        }

        private void QL_DDH_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
            this.Hide();
        }
    }
}
