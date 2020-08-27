using System;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class XacNhanNhapHang : Form
    {
        BUS_XacNhanHangHoa bus_xnhh = new BUS_XacNhanHangHoa();
        public XacNhanNhapHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaQuanLy.Text.ToString()))
            {
                MessageBox.Show("Vui Lòng Nhập Mã Quản Lý", "Thông Báo");
            }
            else
            {
                dataGridView1.DataSource = bus_xnhh.GetDonNhapHang(Convert.ToInt32(MaQuanLy.Text));
                dataGridView2.DataSource = bus_xnhh.GetDonTraHang(Convert.ToInt32(MaQuanLy.Text));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "XacNhan")
            {
                if (MessageBox.Show("Bạn muốn xác nhận đơn nhập hàng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_xnhh.UpdateXacNhanNhap(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), 1, Convert.ToInt32(MaQuanLy.Text)))
                    {
                        MessageBox.Show("Bạn đã xác nhận đơn nhập hàng", "Thông Báo");
                        dataGridView1.DataSource = bus_xnhh.GetDonNhapHang(Convert.ToInt32(MaQuanLy.Text));
                    }
                    else
                        MessageBox.Show("Xác Nhận không thành công", "Thông Báo");
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "KhongXacNhan")
            {
                if (MessageBox.Show("Bạn muốn không xác nhận đơn nhập hàng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_xnhh.UpdateXacNhanNhap(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), 2, Convert.ToInt32(MaQuanLy.Text)))
                    {
                        MessageBox.Show("Bạn đã không xác nhận đơn nhập hàng", "Thông Báo");
                        dataGridView1.DataSource = bus_xnhh.GetDonNhapHang(Convert.ToInt32(MaQuanLy.Text));
                    }
                    else
                        MessageBox.Show("Không thành công", "Thông Báo");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "XacNhan1")
            {
                if (MessageBox.Show("Bạn muốn xác nhận đơn trả hàng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_xnhh.UpdateXacNhanTra(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()), 1, Convert.ToInt32(MaQuanLy.Text)))
                    {
                        MessageBox.Show("Bạn đã xác nhận đơn trả hàng", "Thông Báo");
                        dataGridView2.DataSource = bus_xnhh.GetDonTraHang(Convert.ToInt32(MaQuanLy.Text));
                    }
                    else
                        MessageBox.Show("Xác Nhận không thành công", "Thông Báo");
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "khongxacnhan1")
            {
                if (MessageBox.Show("Bạn muốn không xác nhận đơn trả hàng ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_xnhh.UpdateXacNhanTra(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()), 2, Convert.ToInt32(MaQuanLy.Text)))
                    {
                        MessageBox.Show("Bạn đã không xác nhận đơn trả hàng", "Thông Báo");
                        dataGridView2.DataSource = bus_xnhh.GetDonTraHang(Convert.ToInt32(MaQuanLy.Text));
                    }
                    else
                        MessageBox.Show("Không thành công", "Thông Báo");
                }
            }
        }

        private void XacNhanNhapHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
