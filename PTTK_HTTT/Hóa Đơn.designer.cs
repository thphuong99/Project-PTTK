namespace GUI
{
    partial class Hóa_Đơn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvTTSP = new System.Windows.Forms.ListView();
            this.soLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sanPham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hdTongCong = new System.Windows.Forms.Label();
            this.hdTrangThaiDonHang = new System.Windows.Forms.Label();
            this.hdSanPham = new System.Windows.Forms.Label();
            this.hdTenKhachHang = new System.Windows.Forms.Label();
            this.hdSoDienThoai = new System.Windows.Forms.Label();
            this.hdDiaChiGiaoHang = new System.Windows.Forms.Label();
            this.Thoát = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hdPnThe = new System.Windows.Forms.Panel();
            this.hdSoTaiKhoan = new System.Windows.Forms.Label();
            this.hdTenNganHang = new System.Windows.Forms.Label();
            this.hdTenChuThe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.hdPnThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ giao hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tài khoản:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên ngân hàng:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // lvTTSP
            // 
            this.lvTTSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.soLuong,
            this.sanPham,
            this.donGia,
            this.thanhTien});
            this.lvTTSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTTSP.GridLines = true;
            this.lvTTSP.HideSelection = false;
            this.lvTTSP.Location = new System.Drawing.Point(375, 67);
            this.lvTTSP.Name = "lvTTSP";
            this.lvTTSP.Size = new System.Drawing.Size(401, 208);
            this.lvTTSP.TabIndex = 8;
            this.lvTTSP.UseCompatibleStateImageBehavior = false;
            this.lvTTSP.View = System.Windows.Forms.View.Details;
            this.lvTTSP.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // soLuong
            // 
            this.soLuong.Text = "Số lượng";
            this.soLuong.Width = 98;
            // 
            // sanPham
            // 
            this.sanPham.Text = "Sản phẩm";
            this.sanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sanPham.Width = 104;
            // 
            // donGia
            // 
            this.donGia.Text = "Đơn giá";
            this.donGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.donGia.Width = 70;
            // 
            // thanhTien
            // 
            this.thanhTien.Text = "Thành tiền";
            this.thanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thanhTien.Width = 124;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tên chủ thẻ:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Sản phẩm:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hdTongCong);
            this.panel1.Controls.Add(this.hdTrangThaiDonHang);
            this.panel1.Controls.Add(this.hdSanPham);
            this.panel1.Controls.Add(this.hdTenKhachHang);
            this.panel1.Controls.Add(this.hdSoDienThoai);
            this.panel1.Controls.Add(this.hdDiaChiGiaoHang);
            this.panel1.Controls.Add(this.Thoát);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.hdPnThe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lvTTSP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(26, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 366);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hdTongCong
            // 
            this.hdTongCong.AutoSize = true;
            this.hdTongCong.Location = new System.Drawing.Point(622, 313);
            this.hdTongCong.Name = "hdTongCong";
            this.hdTongCong.Size = new System.Drawing.Size(20, 17);
            this.hdTongCong.TabIndex = 21;
            this.hdTongCong.Text = "...";
            // 
            // hdTrangThaiDonHang
            // 
            this.hdTrangThaiDonHang.AutoSize = true;
            this.hdTrangThaiDonHang.Location = new System.Drawing.Point(622, 288);
            this.hdTrangThaiDonHang.Name = "hdTrangThaiDonHang";
            this.hdTrangThaiDonHang.Size = new System.Drawing.Size(20, 17);
            this.hdTrangThaiDonHang.TabIndex = 20;
            this.hdTrangThaiDonHang.Text = "...";
            // 
            // hdSanPham
            // 
            this.hdSanPham.AutoSize = true;
            this.hdSanPham.Location = new System.Drawing.Point(162, 163);
            this.hdSanPham.Name = "hdSanPham";
            this.hdSanPham.Size = new System.Drawing.Size(20, 17);
            this.hdSanPham.TabIndex = 19;
            this.hdSanPham.Text = "...";
            this.hdSanPham.Click += new System.EventHandler(this.label17_Click);
            // 
            // hdTenKhachHang
            // 
            this.hdTenKhachHang.AutoSize = true;
            this.hdTenKhachHang.Location = new System.Drawing.Point(162, 78);
            this.hdTenKhachHang.Name = "hdTenKhachHang";
            this.hdTenKhachHang.Size = new System.Drawing.Size(20, 17);
            this.hdTenKhachHang.TabIndex = 16;
            this.hdTenKhachHang.Text = "...";
            // 
            // hdSoDienThoai
            // 
            this.hdSoDienThoai.AutoSize = true;
            this.hdSoDienThoai.Location = new System.Drawing.Point(162, 134);
            this.hdSoDienThoai.Name = "hdSoDienThoai";
            this.hdSoDienThoai.Size = new System.Drawing.Size(20, 17);
            this.hdSoDienThoai.TabIndex = 18;
            this.hdSoDienThoai.Text = "...";
            // 
            // hdDiaChiGiaoHang
            // 
            this.hdDiaChiGiaoHang.AutoSize = true;
            this.hdDiaChiGiaoHang.Location = new System.Drawing.Point(162, 107);
            this.hdDiaChiGiaoHang.Name = "hdDiaChiGiaoHang";
            this.hdDiaChiGiaoHang.Size = new System.Drawing.Size(20, 17);
            this.hdDiaChiGiaoHang.TabIndex = 17;
            this.hdDiaChiGiaoHang.Text = "...";
            this.hdDiaChiGiaoHang.Click += new System.EventHandler(this.label15_Click);
            // 
            // Thoát
            // 
            this.Thoát.BackColor = System.Drawing.Color.Lime;
            this.Thoát.Location = new System.Drawing.Point(720, 313);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(123, 42);
            this.Thoát.TabIndex = 15;
            this.Thoát.Text = "Về trang chủ";
            this.Thoát.UseVisualStyleBackColor = false;
            this.Thoát.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(475, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tổng cộng:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Trạng thái đơn hàng:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // hdPnThe
            // 
            this.hdPnThe.Controls.Add(this.hdSoTaiKhoan);
            this.hdPnThe.Controls.Add(this.hdTenNganHang);
            this.hdPnThe.Controls.Add(this.hdTenChuThe);
            this.hdPnThe.Controls.Add(this.label9);
            this.hdPnThe.Controls.Add(this.label5);
            this.hdPnThe.Controls.Add(this.label6);
            this.hdPnThe.Location = new System.Drawing.Point(33, 210);
            this.hdPnThe.Name = "hdPnThe";
            this.hdPnThe.Size = new System.Drawing.Size(220, 107);
            this.hdPnThe.TabIndex = 12;
            // 
            // hdSoTaiKhoan
            // 
            this.hdSoTaiKhoan.AutoSize = true;
            this.hdSoTaiKhoan.Location = new System.Drawing.Point(114, 78);
            this.hdSoTaiKhoan.Name = "hdSoTaiKhoan";
            this.hdSoTaiKhoan.Size = new System.Drawing.Size(20, 17);
            this.hdSoTaiKhoan.TabIndex = 19;
            this.hdSoTaiKhoan.Text = "...";
            // 
            // hdTenNganHang
            // 
            this.hdTenNganHang.AutoSize = true;
            this.hdTenNganHang.Location = new System.Drawing.Point(114, 46);
            this.hdTenNganHang.Name = "hdTenNganHang";
            this.hdTenNganHang.Size = new System.Drawing.Size(20, 17);
            this.hdTenNganHang.TabIndex = 18;
            this.hdTenNganHang.Text = "...";
            // 
            // hdTenChuThe
            // 
            this.hdTenChuThe.AutoSize = true;
            this.hdTenChuThe.Location = new System.Drawing.Point(114, 11);
            this.hdTenChuThe.Name = "hdTenChuThe";
            this.hdTenChuThe.Size = new System.Drawing.Size(20, 17);
            this.hdTenChuThe.TabIndex = 17;
            this.hdTenChuThe.Text = "...";
            // 
            // Hóa_Đơn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(10)));
            this.Name = "Hóa_Đơn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa_Đơn";
            this.Load += new System.EventHandler(this.Hóa_Đơn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hdPnThe.ResumeLayout(false);
            this.hdPnThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvTTSP;
        private System.Windows.Forms.ColumnHeader soLuong;
        private System.Windows.Forms.ColumnHeader sanPham;
        private System.Windows.Forms.ColumnHeader donGia;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel hdPnThe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Label hdTongCong;
        private System.Windows.Forms.Label hdTrangThaiDonHang;
        private System.Windows.Forms.Label hdSanPham;
        private System.Windows.Forms.Label hdSoDienThoai;
        private System.Windows.Forms.Label hdDiaChiGiaoHang;
        private System.Windows.Forms.Label hdTenKhachHang;
        private System.Windows.Forms.Label hdSoTaiKhoan;
        private System.Windows.Forms.Label hdTenNganHang;
        private System.Windows.Forms.Label hdTenChuThe;
    }
}