using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using SchoolManagement.BUS;


namespace SchoolManagement.GUI
{
    public partial class fLogin : Form
    {
        procBUS proc = new procBUS();
        public static string id = "";
        public static string userName = "";
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            id = txtUsername.Text.Substring(2);
            userName = txtUsername.Text;
            int code = proc.Login(txtUsername.Text,txtPassword.Text);
            if (code == 0)
            {
                MessageBox.Show("Chào mừng Giáo Viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmGVAcc newManage = new frmGVAcc();
                this.Hide();
                newManage.ShowDialog();
                this.Show();

            }
            else if (code == 1)
            {
                MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain newManage = new frmMain();
                this.Hide();
                newManage.ShowDialog();
                this.Show();
            }

            else if (code == 2)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
