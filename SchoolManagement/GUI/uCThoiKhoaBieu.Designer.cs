namespace SchoolManagement.GUI
{
    partial class uCThoiKhoaBieu
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
            this.btnWatchTT = new System.Windows.Forms.Button();
            this.cbClassTT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTimeTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYearTT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWatchTT
            // 
            this.btnWatchTT.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.btnWatchTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWatchTT.Location = new System.Drawing.Point(293, 67);
            this.btnWatchTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWatchTT.Name = "btnWatchTT";
            this.btnWatchTT.Size = new System.Drawing.Size(93, 60);
            this.btnWatchTT.TabIndex = 14;
            this.btnWatchTT.Text = "Xem";
            this.btnWatchTT.UseVisualStyleBackColor = true;
            // 
            // cbClassTT
            // 
            this.cbClassTT.FormattingEnabled = true;
            this.cbClassTT.Location = new System.Drawing.Point(106, 55);
            this.cbClassTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbClassTT.Name = "cbClassTT";
            this.cbClassTT.Size = new System.Drawing.Size(160, 24);
            this.cbClassTT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lớp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(528, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thời Khóa Biểu";
            // 
            // dtgTimeTable
            // 
            this.dtgTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTimeTable.Location = new System.Drawing.Point(4, 135);
            this.dtgTimeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgTimeTable.Name = "dtgTimeTable";
            this.dtgTimeTable.RowHeadersWidth = 51;
            this.dtgTimeTable.Size = new System.Drawing.Size(1335, 473);
            this.dtgTimeTable.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Năm học";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbYearTT
            // 
            this.cbYearTT.FormattingEnabled = true;
            this.cbYearTT.Location = new System.Drawing.Point(106, 108);
            this.cbYearTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbYearTT.Name = "cbYearTT";
            this.cbYearTT.Size = new System.Drawing.Size(160, 24);
            this.cbYearTT.TabIndex = 17;
            // 
            // uCThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbYearTT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgTimeTable);
            this.Controls.Add(this.btnWatchTT);
            this.Controls.Add(this.cbClassTT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uCThoiKhoaBieu";
            this.Size = new System.Drawing.Size(1357, 629);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWatchTT;
        private System.Windows.Forms.ComboBox cbClassTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgTimeTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYearTT;
    }
}
