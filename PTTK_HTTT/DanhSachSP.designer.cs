namespace GUI
{
    partial class DanhSachSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvDSSP = new System.Windows.Forms.DataGridView();
            this.dtgvSPDatHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTimKiemSP = new System.Windows.Forms.TextBox();
            this.btnTimKiemSP = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSPDatHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDSSP
            // 
            this.dtgvDSSP.AllowUserToDeleteRows = false;
            this.dtgvDSSP.AllowUserToOrderColumns = true;
            this.dtgvDSSP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSSP.Location = new System.Drawing.Point(16, 142);
            this.dtgvDSSP.Name = "dtgvDSSP";
            this.dtgvDSSP.ReadOnly = true;
            this.dtgvDSSP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSSP.RowHeadersWidth = 51;
            this.dtgvDSSP.RowTemplate.Height = 24;
            this.dtgvDSSP.Size = new System.Drawing.Size(578, 528);
            this.dtgvDSSP.TabIndex = 0;
            this.dtgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSP_CellClick);
            this.dtgvDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSSP_CellContentClick);
            // 
            // dtgvSPDatHang
            // 
            this.dtgvSPDatHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvSPDatHang.ColumnHeadersHeight = 29;
            this.dtgvSPDatHang.Location = new System.Drawing.Point(627, 142);
            this.dtgvSPDatHang.Name = "dtgvSPDatHang";
            this.dtgvSPDatHang.RowHeadersWidth = 51;
            this.dtgvSPDatHang.RowTemplate.Height = 24;
            this.dtgvSPDatHang.Size = new System.Drawing.Size(632, 440);
            this.dtgvSPDatHang.TabIndex = 1;
            this.dtgvSPDatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSPDatHang_CellClick);
            this.dtgvSPDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSPDatHang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐẶT HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "TÌM SẢN PHẨM: ";
            // 
            // txbTimKiemSP
            // 
            this.txbTimKiemSP.Location = new System.Drawing.Point(199, 100);
            this.txbTimKiemSP.Name = "txbTimKiemSP";
            this.txbTimKiemSP.Size = new System.Drawing.Size(395, 22);
            this.txbTimKiemSP.TabIndex = 4;
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.AutoSize = true;
            this.btnTimKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiemSP.Location = new System.Drawing.Point(627, 98);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(155, 27);
            this.btnTimKiemSP.TabIndex = 1;
            this.btnTimKiemSP.Text = "Tìm kiếm";
            this.btnTimKiemSP.UseVisualStyleBackColor = true;
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDatHang.Location = new System.Drawing.Point(967, 631);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(292, 39);
            this.btnDatHang.TabIndex = 6;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(843, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng cộng:";
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.ForeColor = System.Drawing.Color.Red;
            this.txbTongTien.Location = new System.Drawing.Point(967, 595);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.ReadOnly = true;
            this.txbTongTien.Size = new System.Drawing.Size(292, 27);
            this.txbTongTien.TabIndex = 9;
            this.txbTongTien.Text = "0";
            this.txbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTongTien.TextChanged += new System.EventHandler(this.txbTongTien_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTongTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDatHang);
            this.panel1.Controls.Add(this.btnTimKiemSP);
            this.panel1.Controls.Add(this.txbTimKiemSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtgvSPDatHang);
            this.panel1.Controls.Add(this.dtgvDSSP);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 700);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DanhSachSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "DanhSachSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhSachSP_FormClosed);
            this.Load += new System.EventHandler(this.DanhSachSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSPDatHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDSSP;
        private System.Windows.Forms.DataGridView dtgvSPDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTimKiemSP;
        private System.Windows.Forms.Button btnTimKiemSP;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.Panel panel1;
        //private demo.BAN_HANGDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
    }
}