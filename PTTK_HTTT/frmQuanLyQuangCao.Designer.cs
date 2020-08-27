namespace GUI
{
    partial class frmQuanLyQuangCao
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
            this.cbxTenDoiTac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDang = new System.Windows.Forms.Button();
            this.dgvTinDangQC = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOIDANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHOPDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.MAHDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDOITAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRIDANGQC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinDangQC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTenDoiTac
            // 
            this.cbxTenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenDoiTac.FormattingEnabled = true;
            this.cbxTenDoiTac.Location = new System.Drawing.Point(163, 88);
            this.cbxTenDoiTac.Name = "cbxTenDoiTac";
            this.cbxTenDoiTac.Size = new System.Drawing.Size(305, 28);
            this.cbxTenDoiTac.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đối tác:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(163, 129);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(305, 100);
            this.txtNoiDung.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(163, 49);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(305, 27);
            this.txtMaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV thực hiện:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnDang);
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(350, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(174, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 43);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDang
            // 
            this.btnDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDang.Location = new System.Drawing.Point(3, 5);
            this.btnDang.Name = "btnDang";
            this.btnDang.Size = new System.Drawing.Size(124, 43);
            this.btnDang.TabIndex = 0;
            this.btnDang.Text = "Đăng";
            this.btnDang.UseVisualStyleBackColor = true;
            this.btnDang.Click += new System.EventHandler(this.btnDang_Click);
            // 
            // dgvTinDangQC
            // 
            this.dgvTinDangQC.AllowUserToOrderColumns = true;
            this.dgvTinDangQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinDangQC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOIDUNG,
            this.NGUOIDANG,
            this.NGAYDANG,
            this.NGAYSUA,
            this.MAHOPDONG});
            this.dgvTinDangQC.Location = new System.Drawing.Point(10, 26);
            this.dgvTinDangQC.Name = "dgvTinDangQC";
            this.dgvTinDangQC.RowHeadersWidth = 51;
            this.dgvTinDangQC.RowTemplate.Height = 24;
            this.dgvTinDangQC.Size = new System.Drawing.Size(1251, 243);
            this.dgvTinDangQC.TabIndex = 0;
            this.dgvTinDangQC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinDangQC_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 400;
            // 
            // NGUOIDANG
            // 
            this.NGUOIDANG.DataPropertyName = "NGUOIDANG";
            this.NGUOIDANG.HeaderText = "Mã người đăng";
            this.NGUOIDANG.MinimumWidth = 6;
            this.NGUOIDANG.Name = "NGUOIDANG";
            this.NGUOIDANG.Width = 150;
            // 
            // NGAYDANG
            // 
            this.NGAYDANG.DataPropertyName = "NGAYDANG";
            this.NGAYDANG.HeaderText = "Ngày đăng";
            this.NGAYDANG.MinimumWidth = 6;
            this.NGAYDANG.Name = "NGAYDANG";
            this.NGAYDANG.Width = 125;
            // 
            // NGAYSUA
            // 
            this.NGAYSUA.DataPropertyName = "NGAYSUA";
            this.NGAYSUA.HeaderText = "Ngày sửa";
            this.NGAYSUA.MinimumWidth = 6;
            this.NGAYSUA.Name = "NGAYSUA";
            this.NGAYSUA.Width = 125;
            // 
            // MAHOPDONG
            // 
            this.MAHOPDONG.DataPropertyName = "MAHOPDONG";
            this.MAHOPDONG.HeaderText = "Mã hợp đồng";
            this.MAHOPDONG.MinimumWidth = 6;
            this.MAHOPDONG.Name = "MAHOPDONG";
            this.MAHOPDONG.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTinDangQC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 275);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tin quảng cáo";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHDONG,
            this.TENDOITAC,
            this.NGAYLAP,
            this.VITRIDANGQC,
            this.THOIHAN});
            this.dgvHopDong.Location = new System.Drawing.Point(6, 21);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.Size = new System.Drawing.Size(775, 314);
            this.dgvHopDong.TabIndex = 3;
            // 
            // MAHDONG
            // 
            this.MAHDONG.DataPropertyName = "MAHOPDONG";
            this.MAHDONG.HeaderText = "Mã hợp đồng";
            this.MAHDONG.MinimumWidth = 6;
            this.MAHDONG.Name = "MAHDONG";
            this.MAHDONG.Width = 75;
            // 
            // TENDOITAC
            // 
            this.TENDOITAC.DataPropertyName = "TENDOITAC";
            this.TENDOITAC.HeaderText = "Tên đối tác";
            this.TENDOITAC.MinimumWidth = 6;
            this.TENDOITAC.Name = "TENDOITAC";
            this.TENDOITAC.Width = 125;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Width = 125;
            // 
            // VITRIDANGQC
            // 
            this.VITRIDANGQC.DataPropertyName = "VITRIDANGQC";
            this.VITRIDANGQC.HeaderText = "Link đăng quảng cáo";
            this.VITRIDANGQC.MinimumWidth = 6;
            this.VITRIDANGQC.Name = "VITRIDANGQC";
            this.VITRIDANGQC.Width = 200;
            // 
            // THOIHAN
            // 
            this.THOIHAN.DataPropertyName = "THOIHAN";
            this.THOIHAN.HeaderText = "Thời hạn (ngày)";
            this.THOIHAN.MinimumWidth = 6;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHopDong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(492, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 351);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hợp đồng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxTenDoiTac);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtNoiDung);
            this.groupBox3.Controls.Add(this.txtMaNV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 277);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý tin quảng cáo";
            // 
            // frmQuanLyQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "frmQuanLyQuangCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangQuangCao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLyQuangCao_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLyQuangCao_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinDangQC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTenDoiTac;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvTinDangQC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOIDANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOPDONG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHDONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDOITAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VITRIDANGQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIHAN;
    }
}