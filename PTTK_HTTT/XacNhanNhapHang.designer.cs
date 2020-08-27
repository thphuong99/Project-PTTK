namespace GUI
{
    partial class XacNhanNhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ÍD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVPhuTrachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.KhongXacNhan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.donNhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaQuanLy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVPHUTRACHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XacNhan1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.khongxacnhan1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.donTraHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donNhapHangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donTraHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(52, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(979, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Đơn Nhập Hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ÍD,
            this.TenSp,
            this.soluongDataGridViewTextBoxColumn,
            this.nVPhuTrachDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.NCC,
            this.XacNhan,
            this.KhongXacNhan});
            this.dataGridView1.DataSource = this.donNhapHangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(963, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ÍD
            // 
            this.ÍD.DataPropertyName = "id";
            this.ÍD.HeaderText = "ID";
            this.ÍD.MinimumWidth = 6;
            this.ÍD.Name = "ÍD";
            this.ÍD.ReadOnly = true;
            this.ÍD.Width = 20;
            // 
            // TenSp
            // 
            this.TenSp.DataPropertyName = "TenSP";
            this.TenSp.HeaderText = "Tên Sản Phẩm";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.ReadOnly = true;
            this.TenSp.Width = 110;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            this.soluongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soluongDataGridViewTextBoxColumn.Width = 80;
            // 
            // nVPhuTrachDataGridViewTextBoxColumn
            // 
            this.nVPhuTrachDataGridViewTextBoxColumn.DataPropertyName = "NVPhuTrach";
            this.nVPhuTrachDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            this.nVPhuTrachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nVPhuTrachDataGridViewTextBoxColumn.Name = "nVPhuTrachDataGridViewTextBoxColumn";
            this.nVPhuTrachDataGridViewTextBoxColumn.ReadOnly = true;
            this.nVPhuTrachDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "TenNCC";
            this.NCC.HeaderText = "Nhà Cung Cấp";
            this.NCC.MinimumWidth = 6;
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            this.NCC.Width = 110;
            // 
            // XacNhan
            // 
            this.XacNhan.DataPropertyName = "Xác Nhận";
            this.XacNhan.HeaderText = "Xác Nhận";
            this.XacNhan.MinimumWidth = 6;
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.ReadOnly = true;
            this.XacNhan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XacNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.XacNhan.Text = "Xác Nhận";
            this.XacNhan.UseColumnTextForButtonValue = true;
            this.XacNhan.Width = 80;
            // 
            // KhongXacNhan
            // 
            this.KhongXacNhan.DataPropertyName = "Không Xác Nhận";
            this.KhongXacNhan.HeaderText = "Không Xác Nhận";
            this.KhongXacNhan.MinimumWidth = 6;
            this.KhongXacNhan.Name = "KhongXacNhan";
            this.KhongXacNhan.ReadOnly = true;
            this.KhongXacNhan.Text = "Không Xác Nhận";
            this.KhongXacNhan.UseColumnTextForButtonValue = true;
            this.KhongXacNhan.Width = 125;
            // 
            // donNhapHangBindingSource
            // 
            this.donNhapHangBindingSource.DataSource = typeof(DTO.DonNhapHang);
            // 
            // MaQuanLy
            // 
            this.MaQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaQuanLy.Location = new System.Drawing.Point(1125, 175);
            this.MaQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.MaQuanLy.Name = "MaQuanLy";
            this.MaQuanLy.Size = new System.Drawing.Size(60, 27);
            this.MaQuanLy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1104, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hiển Thị Danh Sách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1099, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Quản Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(849, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "XÁC NHẬN ĐƠN NHẬP HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(52, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(979, 310);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Đơn Trả Hàng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn1,
            this.ngayTraDataGridViewTextBoxColumn,
            this.nVPHUTRACHDataGridViewTextBoxColumn1,
            this.XacNhan1,
            this.khongxacnhan1});
            this.dataGridView2.DataSource = this.donTraHangBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(963, 279);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // soLuongDataGridViewTextBoxColumn1
            // 
            this.soLuongDataGridViewTextBoxColumn1.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn1.Name = "soLuongDataGridViewTextBoxColumn1";
            this.soLuongDataGridViewTextBoxColumn1.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // nVPHUTRACHDataGridViewTextBoxColumn1
            // 
            this.nVPHUTRACHDataGridViewTextBoxColumn1.DataPropertyName = "NVPHUTRACH";
            this.nVPHUTRACHDataGridViewTextBoxColumn1.HeaderText = "Nhân Viên";
            this.nVPHUTRACHDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nVPHUTRACHDataGridViewTextBoxColumn1.Name = "nVPHUTRACHDataGridViewTextBoxColumn1";
            this.nVPHUTRACHDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nVPHUTRACHDataGridViewTextBoxColumn1.Width = 125;
            // 
            // XacNhan1
            // 
            this.XacNhan1.DataPropertyName = "Xác Nhận";
            this.XacNhan1.HeaderText = "Xác Nhận";
            this.XacNhan1.MinimumWidth = 6;
            this.XacNhan1.Name = "XacNhan1";
            this.XacNhan1.ReadOnly = true;
            this.XacNhan1.Text = "Xác Nhận";
            this.XacNhan1.UseColumnTextForButtonValue = true;
            this.XacNhan1.Width = 125;
            // 
            // khongxacnhan1
            // 
            this.khongxacnhan1.DataPropertyName = "Không Xác Nhận";
            this.khongxacnhan1.HeaderText = "Không Xác Nhận";
            this.khongxacnhan1.MinimumWidth = 6;
            this.khongxacnhan1.Name = "khongxacnhan1";
            this.khongxacnhan1.ReadOnly = true;
            this.khongxacnhan1.Text = "Không Xác Nhận";
            this.khongxacnhan1.UseColumnTextForButtonValue = true;
            this.khongxacnhan1.Width = 125;
            // 
            // donTraHangBindingSource
            // 
            this.donTraHangBindingSource.DataSource = typeof(DTO.DonTraHang);
            // 
            // XacNhanNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaQuanLy);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XacNhanNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XacNhanNhapHang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XacNhanNhapHang_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donNhapHangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donTraHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MaQuanLy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource donNhapHangBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÍD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVPhuTrachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewButtonColumn XacNhan;
        private System.Windows.Forms.DataGridViewButtonColumn KhongXacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource donTraHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVPHUTRACHDataGridViewTextBoxColumn1;

        private System.Windows.Forms.DataGridViewButtonColumn XacNhan1;
        private System.Windows.Forms.DataGridViewButtonColumn khongxacnhan1;
    }
}