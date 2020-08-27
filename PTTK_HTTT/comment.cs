using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class comment : Form
    {
        BUS_Comment bus_comment = new BUS_Comment();
        public comment()
        {
            InitializeComponent();
        }

        public comment(DanhGiaSP f2)
        {
            InitializeComponent();

            try
            {
                TenSP.Text = f2.getTenSanPham();
                MaSP.Text = f2.getMaSanPham();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form a2 = new DanhGiaSP();
            this.Hide();
            a2.ShowDialog();
            this.Show();
            Application.Exit();
        }

        public void showComment_KH()
        {
            DataTable dt = bus_comment.getComment(MaSP.Text);
            dataGridView1.DataSource = dt;
        }

        private void comment_Load(object sender, EventArgs e)
        {
            showComment_KH();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            Comment binhluan = new Comment(HoTen.Text, Email.Text, DiaChi.Text, NoiDung.Text, Convert.ToInt32(MaSP.Text), 0);
            if (bus_comment.InsertComment(binhluan))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                int k = 0;
                foreach (DataRow row in bus_comment.getNguoiDung_Cam().Rows)
                {
                    if (Email.Text == row["EMAIL"].ToString())
                    {
                        k = 1;
                    }
                }
                if (k == 1)
                {
                    MessageBox.Show("Bạn đã bị cấm do có những bình luận không tốt!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            showComment_KH();
        }
    }
}
