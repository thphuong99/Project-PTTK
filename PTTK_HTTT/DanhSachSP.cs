using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class DanhSachSP : Form
    {
        DonHang dh = new DonHang();
        ChiTietDonHang ct = new ChiTietDonHang();
        DAL_ChiTietDonHang dalCT = new DAL_ChiTietDonHang();
        public DanhSachSP()
        {
            InitializeComponent();
            loadDanhSachSanPham();
            //loadDanhSachSanPhamDatHang();
        }

        //void loadDanhSachSanPham()
        //{
        //    string query = "SELECT MASP AS [Mã sản phẩm], TENSP AS [Tên sản phẩm], DONGIA AS [Đơn giá] from [dbo].SANPHAM";

        //    DataProvider provider = new DataProvider();

        //    dtgvDSSP.DataSource = provider.ExecuteQuery(query);

        //}

        private readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        private readonly DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();

        

        #region methods
        void loadDanhSachSanPham()
        {
            dtgvDSSP.DataSource = DAL_SanPham.Instance.loadDanhSachSP();

            dtgvDSSP.Columns.Add(btn);

            addButtonColumn();

            dtgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        //thêm cột button trong dánh sách sản phẩm
        private void addButtonColumn()
        {
            btn.HeaderText = "Thêm vào ĐĐH";
            btn.Name = "button";
            btn.Text = "Thêm";
            btn.UseColumnTextForButtonValue = true;
        }

        private void addButtonDel()
        {
            btnDel.HeaderText = "Xóa khỏi ĐĐH";
            btnDel.Name = "btnDel";
            btnDel.Text = "Xóa";
            btnDel.UseColumnTextForButtonValue = true;
        }




        List<SanPham> searchSanPham(string tukhoa)
        {
            List<SanPham> list =  DAL_SanPham.Instance.searchSanPham(tukhoa);
            return list;
        }

        #endregion


        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            btnTimKiemSP.BackColor = Color.AliceBlue;
            dtgvDSSP.DataSource = searchSanPham(txbTimKiemSP.Text);
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            dtgvSPDatHang.DataSource = null;
        }

        

        private void DanhSachSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bAN_HANGDataSet.SANPHAM' table. You can move, or remove it, as needed.

            //this.sANPHAMTableAdapter.Fill(this.bAN_HANGDataSet.SANPHAM);

            DataGridViewTextBoxColumn dgvcId2 = new DataGridViewTextBoxColumn();
            dgvcId2.HeaderText = "Tên sản phẩm";
            DataGridViewTextBoxColumn dgvcId3 = new DataGridViewTextBoxColumn();
            dgvcId3.HeaderText = "Đơn giá";
            DataGridViewTextBoxColumn dgvcId4 = new DataGridViewTextBoxColumn();
            dgvcId4.HeaderText = "Số lượng";
            DataGridViewTextBoxColumn dgvcId5 = new DataGridViewTextBoxColumn();
            dgvcId5.HeaderText = "Thành tiền";
            DataGridViewButtonColumn dgvcId6 = new DataGridViewButtonColumn();
            dgvcId6.HeaderText = "Xóa";



            dtgvSPDatHang.Columns.Add(dgvcId2);
            dtgvSPDatHang.Columns.Add(dgvcId3);
            dtgvSPDatHang.Columns.Add(dgvcId4);
            dtgvSPDatHang.Columns.Add(dgvcId5);
            dtgvSPDatHang.Columns.Add(btnDel);

            addButtonDel();


            dtgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSPDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDSSP.AllowUserToAddRows = false;
        }


        double tt = 0;
        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(dtgvDSSP.Columns[e.ColumnIndex].Name == "button")
            {
                DataGridViewRow row = dtgvDSSP.CurrentRow;

                dtgvSPDatHang.Rows.Add(row.Cells[2].Value, row.Cells[3].Value.ToString(), 1, row.Cells[3].Value.ToString());

                tt += Convert.ToDouble(row.Cells[3].Value.ToString());
                
            }
            txbTongTien.Text =Convert.ToString(tt);
        }

        //private void loadDanhSachSanPhamDatHang()
        //{
        //    //dtgvSPDatHang.DataSource = constructDataTableDatHang();

        //    //addButtonDel();
        //    dtgvSPDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //}

        private void dtgvSPDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void addDDH(DonHang dh)
        {
            
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            DateTime ngaylap = DateTime.Now;
            // gán gái trị cho dh    
            dh.NGAYLAP = ngaylap.ToString("yyyyMMdd");
            dh.TONGSOLUONG = dtgvSPDatHang.Rows.Count - 1;
           

            double tongtien = 0;
            
            //foreach(DataRow row in dtgvSPDatHang.Rows)
            //{
            //    tongtien += Convert.ToInt32(row.Cells[3].Value.ToString());
            //}

            for(int i=0;i<=dtgvSPDatHang.Rows.Count-2;i++)
            {
                tongtien += Convert.ToDouble(dtgvSPDatHang.Rows[i].Cells[3].Value.ToString());
            }
            dh.TONGTIEN = tongtien;
            dh.TRANGTHAI = 0;
            
            if (DAL_DonHang.Instance.insertDonHang(dh))
            {
                ct.MADH = DAL_DonHang.Instance.getIDDH();
                for (int i = 0; i <= dtgvSPDatHang.Rows.Count - 2; i++)
                {
                    
                    ct.MASP =  Int16.Parse( dtgvSPDatHang.Rows[i].Cells[2].Value.ToString());
                    ct.SOLUONG = 1;
                    ct.THANHTIEN = float.Parse(dtgvSPDatHang.Rows[i].Cells[3].Value.ToString()); 
                    if (dalCT.insertCTDDH(ct))
                    {
                       
                        ThanhToan tt = new ThanhToan();
                        tt.Show();
                        this.Hide();
                    }

                }

            }
            else
            {
                MessageBox.Show("Thêm đơn hàng thất bại");
            }



        }

        private void dtgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvSPDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSPDatHang.Columns[e.ColumnIndex].Name == "btnDel")
            {
                dtgvSPDatHang.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txbTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        double tinhTongTien()
        {
            double tt = 0;           

            return tt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DanhSachSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
