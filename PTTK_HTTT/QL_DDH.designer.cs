namespace GUI
{
    partial class fQLDDH
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
            this.dtgv_ddh = new System.Windows.Forms.DataGridView();
            this.txbSearchDH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ddh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí đơn đặt hàng";
            // 
            // dtgv_ddh
            // 
            this.dtgv_ddh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_ddh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ddh.Location = new System.Drawing.Point(2, 129);
            this.dtgv_ddh.Name = "dtgv_ddh";
            this.dtgv_ddh.RowHeadersWidth = 51;
            this.dtgv_ddh.RowTemplate.Height = 24;
            this.dtgv_ddh.Size = new System.Drawing.Size(1049, 499);
            this.dtgv_ddh.TabIndex = 1;
            this.dtgv_ddh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ddh_CellContentClick);
            // 
            // txbSearchDH
            // 
            this.txbSearchDH.Location = new System.Drawing.Point(1061, 164);
            this.txbSearchDH.Name = "txbSearchDH";
            this.txbSearchDH.Size = new System.Drawing.Size(100, 22);
            this.txbSearchDH.TabIndex = 2;
            this.txbSearchDH.TextChanged += new System.EventHandler(this.txbSearchDH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1057, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm đơn đặt hàng:";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1061, 210);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // fQLDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSearchDH);
            this.Controls.Add(this.dtgv_ddh);
            this.Controls.Add(this.label1);
            this.Name = "fQLDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_DDH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fQLDDH_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ddh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_ddh;
        private System.Windows.Forms.TextBox txbSearchDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
    }
}