namespace GUI
{
    partial class frmNhanTinQC
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
            this.txtNoiDungTN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuiTin = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTinNhan = new System.Windows.Forms.DataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOIGUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYGUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUOINHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDungTN
            // 
            this.txtNoiDungTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungTN.Location = new System.Drawing.Point(149, 142);
            this.txtNoiDungTN.Multiline = true;
            this.txtNoiDungTN.Name = "txtNoiDungTN";
            this.txtNoiDungTN.Size = new System.Drawing.Size(308, 409);
            this.txtNoiDungTN.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(149, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 27);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.ReadOnlyChanged += new System.EventHandler(this.frmNhanTinQC_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nội dung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(149, 54);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(308, 27);
            this.txtTenKH.TabIndex = 2;
            this.txtTenKH.ReadOnlyChanged += new System.EventHandler(this.frmNhanTinQC_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách hàng: ";
            // 
            // btnGuiTin
            // 
            this.btnGuiTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiTin.Location = new System.Drawing.Point(395, 633);
            this.btnGuiTin.Name = "btnGuiTin";
            this.btnGuiTin.Size = new System.Drawing.Size(87, 51);
            this.btnGuiTin.TabIndex = 2;
            this.btnGuiTin.Text = "Gửi tin";
            this.btnGuiTin.UseVisualStyleBackColor = true;
            this.btnGuiTin.Click += new System.EventHandler(this.btnGuiTin_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.EMAIL,
            this.NGAYSINH,
            this.DIACHI});
            this.dgvKhachHang.Location = new System.Drawing.Point(512, 40);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(763, 311);
            this.dgvKhachHang.TabIndex = 3;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã KH";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.Width = 70;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên KH";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 140;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 80;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã nhân viên";
            // 
            // txtMANV
            // 
            this.txtMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(148, 10);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(69, 27);
            this.txtMANV.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMANV);
            this.panel2.Location = new System.Drawing.Point(12, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 51);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoiDungTN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soạn tin";
            // 
            // dgvTinNhan
            // 
            this.dgvTinNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.NOIDUNG,
            this.NGUOIGUI,
            this.NGAYGUI,
            this.NGUOINHAN});
            this.dgvTinNhan.Location = new System.Drawing.Point(514, 385);
            this.dgvTinNhan.Name = "dgvTinNhan";
            this.dgvTinNhan.RowHeadersWidth = 51;
            this.dgvTinNhan.RowTemplate.Height = 24;
            this.dgvTinNhan.Size = new System.Drawing.Size(760, 298);
            this.dgvTinNhan.TabIndex = 4;
            // 
            // Idd
            // 
            this.Idd.DataPropertyName = "ID";
            this.Idd.HeaderText = "ID";
            this.Idd.MinimumWidth = 6;
            this.Idd.Name = "Idd";
            this.Idd.Width = 125;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 125;
            // 
            // NGUOIGUI
            // 
            this.NGUOIGUI.DataPropertyName = "NGUOIGUI";
            this.NGUOIGUI.HeaderText = "Người gửi";
            this.NGUOIGUI.MinimumWidth = 6;
            this.NGUOIGUI.Name = "NGUOIGUI";
            this.NGUOIGUI.Width = 125;
            // 
            // NGAYGUI
            // 
            this.NGAYGUI.DataPropertyName = "NGAYGUI";
            this.NGAYGUI.HeaderText = "Ngày gửi";
            this.NGAYGUI.MinimumWidth = 6;
            this.NGAYGUI.Name = "NGAYGUI";
            this.NGAYGUI.Width = 125;
            // 
            // NGUOINHAN
            // 
            this.NGUOINHAN.DataPropertyName = "NGUOINHAN";
            this.NGUOINHAN.HeaderText = "Mã KH";
            this.NGUOINHAN.MinimumWidth = 6;
            this.NGUOINHAN.Name = "NGUOINHAN";
            this.NGUOINHAN.Width = 125;
            // 
            // frmNhanTinQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.dgvTinNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnGuiTin);
            this.Name = "frmNhanTinQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanTinQC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhanTinQC_FormClosed);
            this.Load += new System.EventHandler(this.frmNhanTinQC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinNhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDungTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuiTin;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTinNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOIGUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYGUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUOINHAN;
    }
}