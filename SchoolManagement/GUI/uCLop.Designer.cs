namespace SchoolManagement.GUI
{
    partial class uCLop
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnInput = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboXemKhoa = new System.Windows.Forms.ComboBox();
            this.dataSet = new System.Data.DataSet();
            this.pnInput.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(166, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 332);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 332);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.btnRefresh);
            this.pnInput.Controls.Add(this.btnXoa);
            this.pnInput.Controls.Add(this.btnSua);
            this.pnInput.Controls.Add(this.btnThem);
            this.pnInput.Controls.Add(this.txtNamHoc);
            this.pnInput.Controls.Add(this.txtTenLop);
            this.pnInput.Controls.Add(this.label10);
            this.pnInput.Controls.Add(this.label7);
            this.pnInput.Controls.Add(this.label6);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInput.Location = new System.Drawing.Point(0, 0);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(277, 511);
            this.pnInput.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(40, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(103, 232);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(138, 20);
            this.txtNamHoc.TabIndex = 12;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(103, 138);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(138, 20);
            this.txtTenLop.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(99, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Chi Tiết Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Năm Học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Lớp:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(398, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Tất Cả";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.btnTimKiem);
            this.pnDisplay.Controls.Add(this.dGV);
            this.pnDisplay.Controls.Add(this.label2);
            this.pnDisplay.Controls.Add(this.label1);
            this.pnDisplay.Controls.Add(this.btnFilter);
            this.pnDisplay.Controls.Add(this.cboXemKhoa);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplay.Location = new System.Drawing.Point(291, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(742, 511);
            this.pnDisplay.TabIndex = 13;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(317, 42);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 27);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(3, 75);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(724, 419);
            this.dGV.TabIndex = 6;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xem Theo Khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xem Thông Tin:";
            // 
            // cboXemKhoa
            // 
            this.cboXemKhoa.FormattingEnabled = true;
            this.cboXemKhoa.Location = new System.Drawing.Point(208, 46);
            this.cboXemKhoa.Name = "cboXemKhoa";
            this.cboXemKhoa.Size = new System.Drawing.Size(103, 21);
            this.cboXemKhoa.TabIndex = 1;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DatasetQL";
            // 
            // uCLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.pnDisplay);
            this.Name = "uCLop";
            this.Size = new System.Drawing.Size(1033, 511);
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.pnDisplay.ResumeLayout(false);
            this.pnDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboXemKhoa;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.Button btnTimKiem;
    }
}
