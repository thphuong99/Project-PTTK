using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmQuanLyQuangCao : Form
    {
        BUS_QuanLyQuangCao bus_quanlyquangcao = new BUS_QuanLyQuangCao();
        public frmQuanLyQuangCao()
        {
            InitializeComponent();
        }

        public void HienThiQC()
        {
            DataTable dt = bus_quanlyquangcao.XemThongTinQC();
            dgvTinDangQC.DataSource = dt;
        }

        public void HienThiHD()
        {
            DataTable dt2 = bus_quanlyquangcao.XemThongTinHopDong();
            dgvHopDong.DataSource = dt2;
        }

        private void btnDang_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            TinQC tinqc = new TinQC(txtNoiDung.Text, Int32.Parse(txtMaNV.Text), curDate.Date, cbxTenDoiTac.SelectedValue.ToString());

            if (bus_quanlyquangcao.ThemTinQuangCao(tinqc))
            {
                HienThiQC();
                
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }
        int Id;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            TinQC tinqc = new TinQC(Id);
            if (bus_quanlyquangcao.XoaTinQuangCao(tinqc))
            {

                HienThiQC();

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void frmQuanLyQuangCao_Load(object sender, EventArgs e)
        {
            HienThiQC();
            HienThiHD();
            cbxTenDoiTac.DataSource = bus_quanlyquangcao.XemThongTinHopDong();
            cbxTenDoiTac.DisplayMember = "TENDOITAC";
            cbxTenDoiTac.ValueMember = "MAHOPDONG";
        }
        
        private void dgvTinDangQC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                Id = Int32.Parse(dgvTinDangQC.Rows[index].Cells["ID"].Value.ToString());
                txtMaNV.Text = dgvTinDangQC.Rows[index].Cells["NGUOIDANG"].Value.ToString();
                txtNoiDung.Text= dgvTinDangQC.Rows[index].Cells["NOIDUNG"].Value.ToString();
                cbxTenDoiTac.Text= dgvTinDangQC.Rows[index].Cells["MAHOPDONG"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime curDate = DateTime.Today;
            TinQC tinqc = new TinQC(Id,txtNoiDung.Text, curDate.Date);
            if (bus_quanlyquangcao.CapNhatTinQuangCao(tinqc))
            {

                HienThiQC();

            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void frmQuanLyQuangCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuanLy ql = new QuanLy();
            ql.Show();
        }
    }
}
