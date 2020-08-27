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
    public partial class QuanLy : Form
    {
        frmQuanLyQuangCao QuanLyTinDang = new frmQuanLyQuangCao();
        frmNhanTinQC TinNhan = new frmNhanTinQC();
        frmHopDong hopDong = new frmHopDong();
        ThongKeHangHoa tk = new ThongKeHangHoa();
        XacNhanNhapHang xacnhan = new XacNhanNhapHang();
        NVQL_comment camxoa = new NVQL_comment();
        BHPL_comment phanloai = new BHPL_comment();
        Home home = new Home();
        fQLDDH dathang = new fQLDDH();
        QL_DDH trahang = new QL_DDH();
        XU_LI_THANH_TOAN tt = new XU_LI_THANH_TOAN();
        
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            QuanLyTinDang.Show();
            this.Hide();
        }

        private void btnPhatTin_Click(object sender, EventArgs e)
        {
            TinNhan.Show();
            this.Hide();
        }

        private void btnTaoHopDong_Click(object sender, EventArgs e)
        {
            hopDong.Show();
            this.Hide();
        }

        private void btnNhapTra_Click(object sender, EventArgs e)
        {
            tk.Show();
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            xacnhan.Show();
            this.Hide();
        }

        private void btnCamXoa_Click(object sender, EventArgs e)
        {
            camxoa.Show();
            this.Hide();
        }

        private void btnCamUser_Click(object sender, EventArgs e)
        {
            phanloai.Show();
            this.Hide();
        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }

        private void btnTTDatHang_Click(object sender, EventArgs e)
        {
            dathang.Show();
            this.Hide();
        }

        private void btnTTtrahang_Click(object sender, EventArgs e)
        {
            trahang.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            tt.Show();
            this.Hide();
        }
    }
}
