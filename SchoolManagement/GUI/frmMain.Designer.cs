namespace SchoolManagement.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMITaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILichGiangDay = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TSMILop = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureWelcome = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIGiaoVien,
            this.TSMIHocSinh,
            this.TSMITaiKhoan,
            this.lịchToolStripMenuItem,
            this.TSMILop,
            this.TSMIMonHoc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIGiaoVien
            // 
            this.TSMIGiaoVien.Name = "TSMIGiaoVien";
            this.TSMIGiaoVien.Size = new System.Drawing.Size(68, 20);
            this.TSMIGiaoVien.Text = "Giáo viên";
            this.TSMIGiaoVien.Click += new System.EventHandler(this.TSMIGiaoVien_Click);
            // 
            // TSMIHocSinh
            // 
            this.TSMIHocSinh.Name = "TSMIHocSinh";
            this.TSMIHocSinh.Size = new System.Drawing.Size(66, 20);
            this.TSMIHocSinh.Text = "Học sinh";
            this.TSMIHocSinh.Click += new System.EventHandler(this.TSMIHocSinh_Click);
            // 
            // TSMITaiKhoan
            // 
            this.TSMITaiKhoan.Name = "TSMITaiKhoan";
            this.TSMITaiKhoan.Size = new System.Drawing.Size(70, 20);
            this.TSMITaiKhoan.Text = "Tài Khoản";
            this.TSMITaiKhoan.Click += new System.EventHandler(this.TSMITaiKhoan_Click);
            // 
            // lịchToolStripMenuItem
            // 
            this.lịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIThoiKhoaBieu,
            this.TSMILichGiangDay});
            this.lịchToolStripMenuItem.Name = "lịchToolStripMenuItem";
            this.lịchToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.lịchToolStripMenuItem.Text = "Lịch";
            // 
            // TSMIThoiKhoaBieu
            // 
            this.TSMIThoiKhoaBieu.Name = "TSMIThoiKhoaBieu";
            this.TSMIThoiKhoaBieu.Size = new System.Drawing.Size(153, 22);
            this.TSMIThoiKhoaBieu.Text = "Thời Khóa Biểu";
            this.TSMIThoiKhoaBieu.Click += new System.EventHandler(this.TSMIThoiKhoaBieu_Click);
            // 
            // TSMILichGiangDay
            // 
            this.TSMILichGiangDay.Name = "TSMILichGiangDay";
            this.TSMILichGiangDay.Size = new System.Drawing.Size(153, 22);
            this.TSMILichGiangDay.Text = "Lịch Giảng dạy";
            this.TSMILichGiangDay.Click += new System.EventHandler(this.TSMILichGiangDay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureWelcome);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 478);
            this.panel1.TabIndex = 3;
            // 
            // TSMILop
            // 
            this.TSMILop.Name = "TSMILop";
            this.TSMILop.Size = new System.Drawing.Size(39, 20);
            this.TSMILop.Text = "Lớp";
            this.TSMILop.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // TSMIMonHoc
            // 
            this.TSMIMonHoc.Name = "TSMIMonHoc";
            this.TSMIMonHoc.Size = new System.Drawing.Size(69, 20);
            this.TSMIMonHoc.Text = "Môn Học";
            this.TSMIMonHoc.Click += new System.EventHandler(this.TSMIMonHoc_Click);
            // 
            // pictureWelcome
            // 
            this.pictureWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pictureWelcome.Image")));
            this.pictureWelcome.Location = new System.Drawing.Point(2, 2);
            this.pictureWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.pictureWelcome.Name = "pictureWelcome";
            this.pictureWelcome.Size = new System.Drawing.Size(1125, 474);
            this.pictureWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWelcome.TabIndex = 2;
            this.pictureWelcome.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "School Mangement";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem TSMIHocSinh;
        private System.Windows.Forms.ToolStripMenuItem TSMITaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem lịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem TSMILichGiangDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureWelcome;
        private System.Windows.Forms.ToolStripMenuItem TSMILop;
        private System.Windows.Forms.ToolStripMenuItem TSMIMonHoc;
    }
}

