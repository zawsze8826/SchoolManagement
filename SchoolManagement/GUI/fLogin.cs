using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "123456";
            string caption = "Notification";
            if (user.Equals(tbUsername.Text) && pass.Equals(tbPassword.Text))
            {
                frmMain newManage = new frmMain();
                this.Hide();
                newManage.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password", caption);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
