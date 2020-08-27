using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class NVQL_comment : Form
    {
        BUS_QL_Comment bus_ql_comment = new BUS_QL_Comment();
        public NVQL_comment()
        {
            InitializeComponent();
        }

        public void showComment_Xau()
        {
            DataTable dt = bus_ql_comment.getComment_Xau();
            dataGridView2.DataSource = dt;
        }

        public void showComment_Tot()
        {
            DataTable dt = bus_ql_comment.getComment_Tot();
            dataGridView1.DataSource = dt;
        }

        private void NVQL_comment_Load(object sender, EventArgs e)
        {
            showComment_Tot();
            showComment_Xau();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bus_ql_comment.DeleteComment(dataGridView2.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Xóa comment thành công!");
            }
            else
            {
                MessageBox.Show("Xóa comment không thành công!");
            }
            showComment_Xau();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bus_ql_comment.InsertNguoiDung_Cam(dataGridView2.CurrentRow.Cells[2].Value.ToString()))
            {
                MessageBox.Show("Cấm người dùng thành công!");
            }
            else
            {
                MessageBox.Show("Cấm người dùng thất bại!");
            }
        }

        private void NVQL_comment_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }

    }
}
