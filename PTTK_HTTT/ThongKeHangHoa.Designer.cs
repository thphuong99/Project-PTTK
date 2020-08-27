namespace GUI
{
    partial class ThongKeHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_ThongKeHangHoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNhanVien = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.donNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maspDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVPhuTrachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xacNhanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongToiThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donNhapHangBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ThongKeHangHoa
            // 
            this.btn_ThongKeHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeHangHoa.Location = new System.Drawing.Point(1037, 155);
            this.btn_ThongKeHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThongKeHangHoa.Name = "btn_ThongKeHangHoa";
            this.btn_ThongKeHangHoa.Size = new System.Drawing.Size(187, 65);
            this.btn_ThongKeHangHoa.TabIndex = 1;
            this.btn_ThongKeHangHoa.Text = "Thống kê hàng hóa";
            this.btn_ThongKeHangHoa.UseVisualStyleBackColor = true;
            this.btn_ThongKeHangHoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhanVien.Location = new System.Drawing.Point(1164, 63);
            this.MaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.Size = new System.Drawing.Size(72, 27);
            this.MaNhanVien.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1037, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 78);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lập Đơn Nhập Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSP,
            this.TenSanPham,
            this.SLTonKho,
            this.SoLuongToiThieu,
            this.SLTra,
            this.SLTTD});
            this.dataGridView1.DataSource = this.donNhapHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(950, 598);
            this.dataGridView1.TabIndex = 0;
            // 
            // donNhapHangBindingSource
            // 
            this.donNhapHangBindingSource.DataSource = typeof(DTO.DonNhapHang);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(974, 629);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hàng Hóa Cần Nhập";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // maspDataGridViewTextBoxColumn
            // 
            this.maspDataGridViewTextBoxColumn.DataPropertyName = "Masp";
            this.maspDataGridViewTextBoxColumn.HeaderText = "Masp";
            this.maspDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maspDataGridViewTextBoxColumn.Name = "maspDataGridViewTextBoxColumn";
            this.maspDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Soluong";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.Width = 125;
            // 
            // nVPhuTrachDataGridViewTextBoxColumn
            // 
            this.nVPhuTrachDataGridViewTextBoxColumn.DataPropertyName = "NVPhuTrach";
            this.nVPhuTrachDataGridViewTextBoxColumn.HeaderText = "NVPhuTrach";
            this.nVPhuTrachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nVPhuTrachDataGridViewTextBoxColumn.Name = "nVPhuTrachDataGridViewTextBoxColumn";
            this.nVPhuTrachDataGridViewTextBoxColumn.Width = 125;
            // 
            // nCCDataGridViewTextBoxColumn
            // 
            this.nCCDataGridViewTextBoxColumn.DataPropertyName = "NCC";
            this.nCCDataGridViewTextBoxColumn.HeaderText = "NCC";
            this.nCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nCCDataGridViewTextBoxColumn.Name = "nCCDataGridViewTextBoxColumn";
            this.nCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // xacNhanDataGridViewTextBoxColumn
            // 
            this.xacNhanDataGridViewTextBoxColumn.DataPropertyName = "XacNhan";
            this.xacNhanDataGridViewTextBoxColumn.HeaderText = "XacNhan";
            this.xacNhanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xacNhanDataGridViewTextBoxColumn.Name = "xacNhanDataGridViewTextBoxColumn";
            this.xacNhanDataGridViewTextBoxColumn.Width = 125;
            // 
            // lydoDataGridViewTextBoxColumn
            // 
            this.lydoDataGridViewTextBoxColumn.DataPropertyName = "Lydo";
            this.lydoDataGridViewTextBoxColumn.HeaderText = "Lydo";
            this.lydoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lydoDataGridViewTextBoxColumn.Name = "lydoDataGridViewTextBoxColumn";
            this.lydoDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1037, 386);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 81);
            this.button3.TabIndex = 5;
            this.button3.Text = "Lập Đơn Trả Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSP";
            this.TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            this.TenSanPham.Width = 130;
            // 
            // SLTonKho
            // 
            this.SLTonKho.DataPropertyName = "SLTonKho";
            this.SLTonKho.HeaderText = "Số Lượng Tồn Kho";
            this.SLTonKho.MinimumWidth = 6;
            this.SLTonKho.Name = "SLTonKho";
            this.SLTonKho.ReadOnly = true;
            this.SLTonKho.Width = 150;
            // 
            // SoLuongToiThieu
            // 
            this.SoLuongToiThieu.DataPropertyName = "SLTOITHIEU";
            this.SoLuongToiThieu.HeaderText = "Số Lượng Tối Thiểu";
            this.SoLuongToiThieu.MinimumWidth = 6;
            this.SoLuongToiThieu.Name = "SoLuongToiThieu";
            this.SoLuongToiThieu.ReadOnly = true;
            this.SoLuongToiThieu.Width = 160;
            // 
            // SLTra
            // 
            this.SLTra.DataPropertyName = "SOLUONGTRA";
            this.SLTra.HeaderText = "Số Lượng Trả";
            this.SLTra.MinimumWidth = 6;
            this.SLTra.Name = "SLTra";
            this.SLTra.ReadOnly = true;
            this.SLTra.Width = 125;
            // 
            // SLTTD
            // 
            this.SLTTD.DataPropertyName = "SOLUONGTRATOIDA";
            this.SLTTD.HeaderText = "Số Lượng Trả Tối Đa";
            this.SLTTD.MinimumWidth = 6;
            this.SLTTD.Name = "SLTTD";
            this.SLTTD.ReadOnly = true;
            this.SLTTD.Width = 180;
            // 
            // ThongKeHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ThongKeHangHoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeHangHoa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKeHangHoa_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donNhapHangBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ThongKeHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaNhanVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource donNhapHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maspDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVPhuTrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xacNhanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongToiThieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTTD;
    }
}