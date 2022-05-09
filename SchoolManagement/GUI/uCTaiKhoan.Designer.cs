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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.ucRefresh = new System.Windows.Forms.Button();
            this.ucTimKiem = new System.Windows.Forms.Button();
            this.ucXoa = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.ucThem = new System.Windows.Forms.Button();
            this.ucSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(1111, 185);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(132, 22);
            this.txtTimKiem.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.txtQuyen);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(391, 417);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(136, 53);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(247, 23);
            this.txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 134);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 23);
            this.txtPassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "MaGV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.MaximumSize = new System.Drawing.Size(133, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quyen";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(136, 222);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(247, 23);
            this.txtMaGV.TabIndex = 2;
            // 
            // txtQuyen
            // 
            this.txtQuyen.Location = new System.Drawing.Point(136, 316);
            this.txtQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(247, 23);
            this.txtQuyen.TabIndex = 2;
            // 
            // ucRefresh
            // 
            this.ucRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ucRefresh.Location = new System.Drawing.Point(763, 178);
            this.ucRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucRefresh.Name = "ucRefresh";
            this.ucRefresh.Size = new System.Drawing.Size(80, 37);
            this.ucRefresh.TabIndex = 24;
            this.ucRefresh.Text = "Làm mới";
            this.ucRefresh.UseVisualStyleBackColor = false;
            // 
            // ucTimKiem
            // 
            this.ucTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.ucTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucTimKiem.Location = new System.Drawing.Point(1262, 178);
            this.ucTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucTimKiem.Name = "ucTimKiem";
            this.ucTimKiem.Size = new System.Drawing.Size(80, 37);
            this.ucTimKiem.TabIndex = 25;
            this.ucTimKiem.Text = "Tìm Kiếm";
            this.ucTimKiem.UseVisualStyleBackColor = false;
            // 
            // ucXoa
            // 
            this.ucXoa.BackColor = System.Drawing.Color.Transparent;
            this.ucXoa.Location = new System.Drawing.Point(649, 178);
            this.ucXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucXoa.Name = "ucXoa";
            this.ucXoa.Size = new System.Drawing.Size(80, 37);
            this.ucXoa.TabIndex = 23;
            this.ucXoa.Text = "Xóa";
            this.ucXoa.UseVisualStyleBackColor = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // ucThem
            // 
            this.ucThem.BackColor = System.Drawing.Color.Transparent;
            this.ucThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucThem.Location = new System.Drawing.Point(419, 178);
            this.ucThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucThem.Name = "ucThem";
            this.ucThem.Size = new System.Drawing.Size(80, 37);
            this.ucThem.TabIndex = 20;
            this.ucThem.Text = "Thêm";
            this.ucThem.UseVisualStyleBackColor = false;
            // 
            // ucSua
            // 
            this.ucSua.BackColor = System.Drawing.Color.Transparent;
            this.ucSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucSua.Location = new System.Drawing.Point(535, 178);
            this.ucSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSua.Name = "ucSua";
            this.ucSua.Size = new System.Drawing.Size(80, 37);
            this.ucSua.TabIndex = 22;
            this.ucSua.Text = "Sửa";
            this.ucSua.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(518, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lí Tài Khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 225);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(936, 382);
            this.dataGridView1.TabIndex = 28;
            // 
            // uCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucRefresh);
            this.Controls.Add(this.ucTimKiem);
            this.Controls.Add(this.ucXoa);
            this.Controls.Add(this.ucThem);
            this.Controls.Add(this.ucSua);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uCTaiKhoan";
            this.Size = new System.Drawing.Size(1377, 629);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button ucRefresh;
        private System.Windows.Forms.Button ucTimKiem;
        private System.Windows.Forms.Button ucXoa;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button ucThem;
        private System.Windows.Forms.Button ucSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
