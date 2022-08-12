namespace BTL_QLSV_WINFORM
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.ht;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật Khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhVienToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.giaoVienToolStripMenuItem,
            this.diemToolStripMenuItem,
            this.lopHocToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.ql;
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.svv;
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.sinhVienToolStripMenuItem.Text = "Sinh Viên ";
            this.sinhVienToolStripMenuItem.Click += new System.EventHandler(this.sinhVienToolStripMenuItem_Click);
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.mh;
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.monHocToolStripMenuItem.Text = "Môn Học";
            this.monHocToolStripMenuItem.Click += new System.EventHandler(this.monHocToolStripMenuItem_Click);
            // 
            // giaoVienToolStripMenuItem
            // 
            this.giaoVienToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.gvt;
            this.giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            this.giaoVienToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.giaoVienToolStripMenuItem.Text = "Giáo Viên";
            this.giaoVienToolStripMenuItem.Click += new System.EventHandler(this.giaoVienToolStripMenuItem_Click);
            // 
            // diemToolStripMenuItem
            // 
            this.diemToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.diemjpg;
            this.diemToolStripMenuItem.Name = "diemToolStripMenuItem";
            this.diemToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.diemToolStripMenuItem.Text = "Điểm ";
            this.diemToolStripMenuItem.Click += new System.EventHandler(this.diemToolStripMenuItem_Click);
            // 
            // lopHocToolStripMenuItem
            // 
            this.lopHocToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.lh;
            this.lopHocToolStripMenuItem.Name = "lopHocToolStripMenuItem";
            this.lopHocToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.lopHocToolStripMenuItem.Text = "Lớp Học ";
            this.lopHocToolStripMenuItem.Click += new System.EventHandler(this.lopHocToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Image = global::BTL_QLSV_WINFORM.Properties.Resources.tg;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1195, 420);
            this.panel.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem lopHocToolStripMenuItem;
    }
}

