namespace SchoolManagement.GUI
{
    partial class uCMonHoc
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
            this.dataSet = new System.Data.DataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtIdMon = new System.Windows.Forms.TextBox();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnInput = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.pnInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DatasetQL";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(166, 417);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(166, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(40, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(103, 237);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(138, 20);
            this.txtTenMon.TabIndex = 11;
            // 
            // txtIdMon
            // 
            this.txtIdMon.Location = new System.Drawing.Point(103, 157);
            this.txtIdMon.Name = "txtIdMon";
            this.txtIdMon.ReadOnly = true;
            this.txtIdMon.Size = new System.Drawing.Size(138, 20);
            this.txtIdMon.TabIndex = 10;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.dGV);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplay.Location = new System.Drawing.Point(291, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(742, 511);
            this.pnDisplay.TabIndex = 15;
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(3, 16);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(727, 481);
            this.dGV.TabIndex = 6;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id Môn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(99, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Môn Học";
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.btnRefresh);
            this.pnInput.Controls.Add(this.btnXoa);
            this.pnInput.Controls.Add(this.btnSua);
            this.pnInput.Controls.Add(this.btnThem);
            this.pnInput.Controls.Add(this.txtTenMon);
            this.pnInput.Controls.Add(this.txtIdMon);
            this.pnInput.Controls.Add(this.label3);
            this.pnInput.Controls.Add(this.label10);
            this.pnInput.Controls.Add(this.label6);
            this.pnInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnInput.Location = new System.Drawing.Point(0, 0);
            this.pnInput.Name = "pnInput";
            this.pnInput.Size = new System.Drawing.Size(277, 511);
            this.pnInput.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Môn:";
            // 
            // uCMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDisplay);
            this.Controls.Add(this.pnInput);
            this.Name = "uCMonHoc";
            this.Size = new System.Drawing.Size(1033, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtIdMon;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Label label6;
    }
}
