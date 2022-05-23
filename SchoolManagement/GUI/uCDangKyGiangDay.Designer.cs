namespace SchoolManagement.GUI
{
    partial class uCDangKyGiangDay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboXemLop = new System.Windows.Forms.ComboBox();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dataSet = new System.Data.DataSet();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnInput = new System.Windows.Forms.Panel();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboTiet = new System.Windows.Forms.ComboBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdTeacher = new System.Windows.Forms.TextBox();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xem Theo Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xem Thông Tin:";
            // 
            // cboXemLop
            // 
            this.cboXemLop.FormattingEnabled = true;
            this.cboXemLop.Location = new System.Drawing.Point(205, 46);
            this.cboXemLop.Name = "cboXemLop";
            this.cboXemLop.Size = new System.Drawing.Size(103, 21);
            this.cboXemLop.TabIndex = 1;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.btnTim);
            this.pnDisplay.Controls.Add(this.dGV);
            this.pnDisplay.Controls.Add(this.label2);
            this.pnDisplay.Controls.Add(this.label1);
            this.pnDisplay.Controls.Add(this.btnFilter);
            this.pnDisplay.Controls.Add(this.cboXemLop);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplay.Location = new System.Drawing.Point(291, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(742, 511);
            this.pnDisplay.TabIndex = 11;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(332, 42);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 27);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(3, 75);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(724, 397);
            this.dGV.TabIndex = 6;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(428, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Tất Cả";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DatasetQL";
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.Location = new System.Drawing.Point(103, 165);
            this.txtGiaoVien.Name = "txtGiaoVien";
            this.txtGiaoVien.ReadOnly = true;
            this.txtGiaoVien.Size = new System.Drawing.Size(138, 20);
            this.txtGiaoVien.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 85);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id Teaching:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giáo Viên:";
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.txtIdTeacher);
            this.pnInput.Controls.Add(this.label4);
            this.pnInput.Controls.Add(this.cboLop);
            this.pnInput.Controls.Add(this.cboTiet);
            this.pnInput.Controls.Add(this.dTP);
            this.pnInput.Controls.Add(this.btnRefresh);
            this.pnInput.Controls.Add(this.btnXoa);
            this.pnInput.Controls.Add(this.btnSua);
            this.pnInput.Controls.Add(this.btnDangKy);
            this.pnInput.Controls.Add(this.txtGiaoVien);
            this.pnInput.Controls.Add(this.txtId);
            this.pnInput.Controls.Add(this.label3);
            this.pnInput.Controls.Add(this.label10);
            this.pnInput.Controls.Add(this.label9);
            this.pnInput.Controls.Add(this.label8);
            this.pnInput.Controls.Add(this.label7);
            this.pnInput.Controls.Add(this.label6);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInput.Location = new System.Drawing.Point(0, 0);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(277, 511);
            this.pnInput.TabIndex = 10;
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(103, 207);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(138, 21);
            this.cboLop.TabIndex = 21;
            // 
            // cboTiet
            // 
            this.cboTiet.Location = new System.Drawing.Point(103, 297);
            this.cboTiet.Name = "cboTiet";
            this.cboTiet.Size = new System.Drawing.Size(138, 21);
            this.cboTiet.TabIndex = 0;
            // 
            // dTP
            // 
            this.dTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP.Location = new System.Drawing.Point(103, 249);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(138, 20);
            this.dTP.TabIndex = 20;
            this.dTP.ValueChanged += new System.EventHandler(this.dTP_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(166, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(41, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 355);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(41, 355);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 27);
            this.btnDangKy.TabIndex = 15;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(61, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Đăng Ký Giảng Dạy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id Teacher:";
            // 
            // txtIdTeacher
            // 
            this.txtIdTeacher.Location = new System.Drawing.Point(103, 125);
            this.txtIdTeacher.Name = "txtIdTeacher";
            this.txtIdTeacher.ReadOnly = true;
            this.txtIdTeacher.Size = new System.Drawing.Size(138, 20);
            this.txtIdTeacher.TabIndex = 23;
            // 
            // uCDangKyGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnInput);
            this.Name = "uCDangKyGiangDay";
            this.Size = new System.Drawing.Size(1033, 511);
            this.pnDisplay.ResumeLayout(false);
            this.pnDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboXemLop;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Button btnFilter;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.TextBox txtGiaoVien;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboTiet;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox txtIdTeacher;
        private System.Windows.Forms.Label label4;
    }
}
