namespace SchoolManagement.GUI
{
    partial class uCGiangDay
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataSet = new System.Data.DataSet();
            this.pnInput = new System.Windows.Forms.Panel();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtTiet = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtGiaoVien = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboXemLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.pnInput.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(61, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Chi Tiết Giảng Dạy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiết:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thứ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giáo Viên:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DatasetQL";
            // 
            // pnInput
            // 
            this.pnInput.Controls.Add(this.txtThu);
            this.pnInput.Controls.Add(this.txtTiet);
            this.pnInput.Controls.Add(this.txtLop);
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
            this.pnInput.TabIndex = 8;
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(103, 330);
            this.txtThu.Name = "txtThu";
            this.txtThu.ReadOnly = true;
            this.txtThu.Size = new System.Drawing.Size(138, 20);
            this.txtThu.TabIndex = 14;
            // 
            // txtTiet
            // 
            this.txtTiet.Location = new System.Drawing.Point(103, 410);
            this.txtTiet.Name = "txtTiet";
            this.txtTiet.ReadOnly = true;
            this.txtTiet.Size = new System.Drawing.Size(138, 20);
            this.txtTiet.TabIndex = 13;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(103, 246);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(138, 20);
            this.txtLop.TabIndex = 12;
            // 
            // txtGiaoVien
            // 
            this.txtGiaoVien.Location = new System.Drawing.Point(103, 167);
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
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.dGV);
            this.pnDisplay.Controls.Add(this.label2);
            this.pnDisplay.Controls.Add(this.label1);
            this.pnDisplay.Controls.Add(this.btnFilter);
            this.pnDisplay.Controls.Add(this.cboXemLop);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnDisplay.Location = new System.Drawing.Point(291, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(742, 511);
            this.pnDisplay.TabIndex = 9;
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
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(334, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Tất Cả";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cboXemLop
            // 
            this.cboXemLop.FormattingEnabled = true;
            this.cboXemLop.Location = new System.Drawing.Point(208, 46);
            this.cboXemLop.Name = "cboXemLop";
            this.cboXemLop.Size = new System.Drawing.Size(103, 21);
            this.cboXemLop.TabIndex = 1;
            this.cboXemLop.SelectedIndexChanged += new System.EventHandler(this.cboXemLop_SelectedIndexChanged);
            // 
            // uCGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnInput);
            this.Controls.Add(this.pnDisplay);
            this.Name = "uCGiangDay";
            this.Size = new System.Drawing.Size(1033, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.pnInput.ResumeLayout(false);
            this.pnInput.PerformLayout();
            this.pnDisplay.ResumeLayout(false);
            this.pnDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.Panel pnInput;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboXemLop;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.TextBox txtTiet;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtGiaoVien;
    }
}
