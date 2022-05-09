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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnTKB = new System.Windows.Forms.Button();
            this.btnGiangDay = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.pictureWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTaiKhoan);
            this.splitContainer1.Panel1.Controls.Add(this.btnTKB);
            this.splitContainer1.Panel1.Controls.Add(this.btnGiangDay);
            this.splitContainer1.Panel1.Controls.Add(this.btnHocSinh);
            this.splitContainer1.Panel1.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel1.Controls.Add(this.btnGiaoVien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureWelcome);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 518);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiKhoan.Image")));
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaiKhoan.Location = new System.Drawing.Point(3, 347);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(92, 80);
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Text = "Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.BackColor = System.Drawing.Color.White;
            this.btnTKB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKB.Image = ((System.Drawing.Image)(resources.GetObject("btnTKB.Image")));
            this.btnTKB.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKB.Location = new System.Drawing.Point(3, 261);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(92, 80);
            this.btnTKB.TabIndex = 5;
            this.btnTKB.Text = "TKB";
            this.btnTKB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTKB.UseVisualStyleBackColor = false;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // btnGiangDay
            // 
            this.btnGiangDay.BackColor = System.Drawing.Color.White;
            this.btnGiangDay.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangDay.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangDay.Image")));
            this.btnGiangDay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiangDay.Location = new System.Drawing.Point(3, 175);
            this.btnGiangDay.Name = "btnGiangDay";
            this.btnGiangDay.Size = new System.Drawing.Size(92, 80);
            this.btnGiangDay.TabIndex = 4;
            this.btnGiangDay.Text = "Giảng Dạy";
            this.btnGiangDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiangDay.UseVisualStyleBackColor = false;
            this.btnGiangDay.Click += new System.EventHandler(this.btnGiangDay_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackColor = System.Drawing.Color.White;
            this.btnHocSinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Image")));
            this.btnHocSinh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocSinh.Location = new System.Drawing.Point(3, 89);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(92, 80);
            this.btnHocSinh.TabIndex = 3;
            this.btnHocSinh.Text = "Học Sinh";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.Location = new System.Drawing.Point(3, 433);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 80);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackColor = System.Drawing.Color.White;
            this.btnGiaoVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaoVien.Location = new System.Drawing.Point(3, 3);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(92, 80);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGiaoVien.UseVisualStyleBackColor = false;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // pictureWelcome
            // 
            this.pictureWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pictureWelcome.Image")));
            this.pictureWelcome.Location = new System.Drawing.Point(2, 2);
            this.pictureWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureWelcome.Name = "pictureWelcome";
            this.pictureWelcome.Size = new System.Drawing.Size(1045, 514);
            this.pictureWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWelcome.TabIndex = 0;
            this.pictureWelcome.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 518);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnTKB;
        private System.Windows.Forms.Button btnGiangDay;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.PictureBox pictureWelcome;
    }
}

