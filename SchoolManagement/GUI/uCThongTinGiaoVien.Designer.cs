namespace SchoolManagement.GUI
{
    partial class uCThongTinGiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uCThongTinGiaoVien));
            this.dGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSearchType = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grbThongTinGiaoVien = new System.Windows.Forms.GroupBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtGt = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbThongTinGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(14, 263);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(1001, 240);
            this.dGV.TabIndex = 20;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cboSearchType);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cboSearchType
            // 
            this.cboSearchType.FormattingEnabled = true;
            this.cboSearchType.Items.AddRange(new object[] {
            "Mã Giáo Viên",
            "Tên",
            "Số Điện Thoại",
            "Tên Môn"});
            this.cboSearchType.Location = new System.Drawing.Point(6, 15);
            this.cboSearchType.Name = "cboSearchType";
            this.cboSearchType.Size = new System.Drawing.Size(121, 23);
            this.cboSearchType.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(235, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(59, 44);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 44);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(204, 23);
            this.txtTimKiem.TabIndex = 2;
            // 
            // grbThongTinGiaoVien
            // 
            this.grbThongTinGiaoVien.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grbThongTinGiaoVien.Controls.Add(this.txtNgaySinh);
            this.grbThongTinGiaoVien.Controls.Add(this.txtGt);
            this.grbThongTinGiaoVien.Controls.Add(this.txtMaMon);
            this.grbThongTinGiaoVien.Controls.Add(this.label2);
            this.grbThongTinGiaoVien.Controls.Add(this.txtTenMon);
            this.grbThongTinGiaoVien.Controls.Add(this.txtMaGV);
            this.grbThongTinGiaoVien.Controls.Add(this.txtLuong);
            this.grbThongTinGiaoVien.Controls.Add(this.txtSDT);
            this.grbThongTinGiaoVien.Controls.Add(this.txtDiaChi);
            this.grbThongTinGiaoVien.Controls.Add(this.txtTen);
            this.grbThongTinGiaoVien.Controls.Add(this.lblTenMon);
            this.grbThongTinGiaoVien.Controls.Add(this.lblLuong);
            this.grbThongTinGiaoVien.Controls.Add(this.lb);
            this.grbThongTinGiaoVien.Controls.Add(this.lblDiaChi);
            this.grbThongTinGiaoVien.Controls.Add(this.lblNgaySinh);
            this.grbThongTinGiaoVien.Controls.Add(this.lblGT);
            this.grbThongTinGiaoVien.Controls.Add(this.lblTen);
            this.grbThongTinGiaoVien.Controls.Add(this.lblMaHS);
            this.grbThongTinGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinGiaoVien.Location = new System.Drawing.Point(14, 8);
            this.grbThongTinGiaoVien.Name = "grbThongTinGiaoVien";
            this.grbThongTinGiaoVien.Size = new System.Drawing.Size(1004, 159);
            this.grbThongTinGiaoVien.TabIndex = 17;
            this.grbThongTinGiaoVien.TabStop = false;
            this.grbThongTinGiaoVien.Text = "Thông tin giáo viên";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(370, 18);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.ReadOnly = true;
            this.txtMaMon.Size = new System.Drawing.Size(61, 22);
            this.txtMaMon.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(503, 18);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(115, 22);
            this.txtTenMon.TabIndex = 24;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(81, 19);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(200, 22);
            this.txtMaGV.TabIndex = 23;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.Location = new System.Drawing.Point(370, 77);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.ReadOnly = true;
            this.txtLuong.Size = new System.Drawing.Size(121, 22);
            this.txtLuong.TabIndex = 20;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(370, 49);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(121, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(370, 105);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(248, 23);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(81, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(200, 22);
            this.txtTen.TabIndex = 11;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMon.Location = new System.Drawing.Point(437, 23);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(54, 15);
            this.lblTenMon.TabIndex = 8;
            this.lblTenMon.Text = "Tên môn";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(310, 80);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(44, 15);
            this.lblLuong.TabIndex = 7;
            this.lblLuong.Text = "Lương";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(310, 47);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(32, 15);
            this.lb.TabIndex = 6;
            this.lb.Text = "SĐT";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(310, 112);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(46, 15);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(15, 112);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(62, 15);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(15, 80);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(56, 15);
            this.lblGT.TabIndex = 3;
            this.lblGT.Text = "Giới tính";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(15, 49);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(46, 15);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Họ Tên";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHS.Location = new System.Drawing.Point(15, 22);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(45, 15);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Image = global::SchoolManagement.Properties.Resources.gVRefresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(351, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 52);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtGt
            // 
            this.txtGt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGt.Location = new System.Drawing.Point(81, 77);
            this.txtGt.Name = "txtGt";
            this.txtGt.ReadOnly = true;
            this.txtGt.Size = new System.Drawing.Size(200, 22);
            this.txtGt.TabIndex = 27;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySinh.Location = new System.Drawing.Point(81, 109);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.txtNgaySinh.TabIndex = 28;
            // 
            // uCThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "uCThongTinGiaoVien";
            this.Size = new System.Drawing.Size(1033, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbThongTinGiaoVien.ResumeLayout(false);
            this.grbThongTinGiaoVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSearchType;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grbThongTinGiaoVien;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtGt;
    }
}
