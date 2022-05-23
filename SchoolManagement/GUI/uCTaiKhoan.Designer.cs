namespace SchoolManagement.GUI
{
    partial class uCTaiKhoan
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.ucRefresh = new System.Windows.Forms.Button();
            this.ucTimKiem = new System.Windows.Forms.Button();
            this.ucXoa = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.ucThem = new System.Windows.Forms.Button();
            this.ucSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(833, 150);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLoaiTK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 339);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(186, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 257);
            this.label5.MaximumSize = new System.Drawing.Size(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "LoaiTK";
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Location = new System.Drawing.Point(102, 257);
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.Size = new System.Drawing.Size(186, 20);
            this.txtLoaiTK.TabIndex = 2;
            // 
            // ucRefresh
            // 
            this.ucRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ucRefresh.Location = new System.Drawing.Point(572, 145);
            this.ucRefresh.Name = "ucRefresh";
            this.ucRefresh.Size = new System.Drawing.Size(60, 30);
            this.ucRefresh.TabIndex = 24;
            this.ucRefresh.Text = "Làm mới";
            this.ucRefresh.UseVisualStyleBackColor = false;
            this.ucRefresh.Click += new System.EventHandler(this.ucRefresh_Click);
            // 
            // ucTimKiem
            // 
            this.ucTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.ucTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucTimKiem.Location = new System.Drawing.Point(946, 145);
            this.ucTimKiem.Name = "ucTimKiem";
            this.ucTimKiem.Size = new System.Drawing.Size(60, 30);
            this.ucTimKiem.TabIndex = 25;
            this.ucTimKiem.Text = "Tìm Kiếm";
            this.ucTimKiem.UseVisualStyleBackColor = false;
            // 
            // ucXoa
            // 
            this.ucXoa.BackColor = System.Drawing.Color.Transparent;
            this.ucXoa.Location = new System.Drawing.Point(487, 145);
            this.ucXoa.Name = "ucXoa";
            this.ucXoa.Size = new System.Drawing.Size(60, 30);
            this.ucXoa.TabIndex = 23;
            this.ucXoa.Text = "Xóa";
            this.ucXoa.UseVisualStyleBackColor = false;
            this.ucXoa.Click += new System.EventHandler(this.ucXoa_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // ucThem
            // 
            this.ucThem.BackColor = System.Drawing.Color.Transparent;
            this.ucThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucThem.Location = new System.Drawing.Point(314, 145);
            this.ucThem.Name = "ucThem";
            this.ucThem.Size = new System.Drawing.Size(60, 30);
            this.ucThem.TabIndex = 20;
            this.ucThem.Text = "Thêm";
            this.ucThem.UseVisualStyleBackColor = false;
            this.ucThem.Click += new System.EventHandler(this.ucThem_Click);
            // 
            // ucSua
            // 
            this.ucSua.BackColor = System.Drawing.Color.Transparent;
            this.ucSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucSua.Location = new System.Drawing.Point(401, 145);
            this.ucSua.Name = "ucSua";
            this.ucSua.Size = new System.Drawing.Size(60, 30);
            this.ucSua.TabIndex = 22;
            this.ucSua.Text = "Sửa";
            this.ucSua.UseVisualStyleBackColor = false;
            this.ucSua.Click += new System.EventHandler(this.ucSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(388, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lí Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(314, 183);
            this.dGV.Name = "dGV";
            this.dGV.RowHeadersWidth = 51;
            this.dGV.Size = new System.Drawing.Size(702, 310);
            this.dGV.TabIndex = 28;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // uCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucRefresh);
            this.Controls.Add(this.ucTimKiem);
            this.Controls.Add(this.ucXoa);
            this.Controls.Add(this.ucThem);
            this.Controls.Add(this.ucSua);
            this.Controls.Add(this.label1);
            this.Name = "uCTaiKhoan";
            this.Size = new System.Drawing.Size(1033, 511);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.Button ucRefresh;
        private System.Windows.Forms.Button ucTimKiem;
        private System.Windows.Forms.Button ucXoa;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button ucThem;
        private System.Windows.Forms.Button ucSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV;
    }
}
