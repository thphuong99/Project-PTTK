namespace GUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sẢNPHẨMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đÁNHGIÁToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sẢNPHẨMToolStripMenuItem,
            this.đÁNHGIÁToolStripMenuItem,
            this.qUẢNLÝToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1287, 43);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sẢNPHẨMToolStripMenuItem
            // 
            this.sẢNPHẨMToolStripMenuItem.Font = new System.Drawing.Font("Jokerman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sẢNPHẨMToolStripMenuItem.Name = "sẢNPHẨMToolStripMenuItem";
            this.sẢNPHẨMToolStripMenuItem.Size = new System.Drawing.Size(170, 39);
            this.sẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM";
            this.sẢNPHẨMToolStripMenuItem.Click += new System.EventHandler(this.sẢNPHẨMToolStripMenuItem_Click);
            // 
            // đÁNHGIÁToolStripMenuItem
            // 
            this.đÁNHGIÁToolStripMenuItem.Font = new System.Drawing.Font("Jokerman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đÁNHGIÁToolStripMenuItem.Name = "đÁNHGIÁToolStripMenuItem";
            this.đÁNHGIÁToolStripMenuItem.Size = new System.Drawing.Size(164, 39);
            this.đÁNHGIÁToolStripMenuItem.Text = "ĐÁNH GIÁ";
            this.đÁNHGIÁToolStripMenuItem.Click += new System.EventHandler(this.đÁNHGIÁToolStripMenuItem_Click);
            // 
            // qUẢNLÝToolStripMenuItem
            // 
            this.qUẢNLÝToolStripMenuItem.Font = new System.Drawing.Font("Jokerman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUẢNLÝToolStripMenuItem.Name = "qUẢNLÝToolStripMenuItem";
            this.qUẢNLÝToolStripMenuItem.Size = new System.Drawing.Size(151, 39);
            this.qUẢNLÝToolStripMenuItem.Text = "QUẢN LÝ";
            this.qUẢNLÝToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÝToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1287, 696);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sẢNPHẨMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đÁNHGIÁToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝToolStripMenuItem;
    }
}