using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmNhanTinQC : Form
    {
        BUS_NhanTinQC bus_nhantinqc = new BUS_NhanTinQC();
        public frmNhanTinQC()
        {
            InitializeComponent();
        }

        public void HienThiKhachHang()
        {
            DataTable dt = bus_nhantinqc.XemThongTinKhachHang();
            dgvKhachHang.DataSource = dt;
        }
        
        public void HienThiTinNhan()
        {
            DataTable dt = bus_nhantinqc.XemTinNhan();
            dgvTinNhan.DataSource = dt;
        }
        
        int Id;
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Id = Int32.Parse(dgvKhachHang.Rows[index].Cells["MAKH"].Value.ToString());
                txtTenKH.Text = dgvKhachHang.Rows[index].Cells["TENKH"].Value.ToString();
                txtEmail.Text= dgvKhachHang.Rows[index].Cells["EMAIL"].Value.ToString();
            }
        }

        private void btnGuiTin_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            TinNhanQC tinnhanqc = new TinNhanQC(txtNoiDungTN.Text, Int32.Parse(txtMANV.Text), curDate.Date, Id);

            if (bus_nhantinqc.ThemTinNhanQC(tinnhanqc))
            {
                HienThiTinNhan();

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void frmNhanTinQC_Load(object sender, EventArgs e)
        {
            HienThiKhachHang();
            HienThiTinNhan();
        }

        private void frmNhanTinQC_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
