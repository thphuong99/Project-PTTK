using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class XU_LI_THANH_TOAN : Form
    {
        BUS_CT_THANHTOAN busTT = new BUS_CT_THANHTOAN();
        int md;
        public XU_LI_THANH_TOAN()
        {          
            InitializeComponent();
            DataTable dt = busTT.layTTDonHang();
            GRV.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kiểm tra cập nhật đơn hàng
            if(busTT.capNhatThanhToan(md))
            {

                MessageBox.Show("Cap nhat thanh cong ");
                this.Hide();
                XU_LI_THANH_TOAN xl = new XU_LI_THANH_TOAN();
                xl.Show();
            }
            else
            {
                MessageBox.Show("Cap nhat that bai ");
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // kiểm kiếm theo mã đơn hàng
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                (GRV.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (GRV.DataSource as DataTable).DefaultView.RowFilter = string.Format("convert(MADH, 'System.String') LIKE '%{0}%'", searchTextBox.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //quay trở lại trang trước
            QuanLy ql = new QuanLy();
            this.Close();
            ql.Show();
        }

        private void GRV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                
                TONGTIEN.Text = GRV.Rows[index].Cells["TONGTIEN"].Value.ToString();
                MADON.Text = GRV.Rows[index].Cells["MADH"].Value.ToString();
                md = Int32.Parse(GRV.Rows[index].Cells["MADH"].Value.ToString());
            }
        }
    }
}
