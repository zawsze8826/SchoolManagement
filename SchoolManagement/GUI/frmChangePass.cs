using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.BUS;
using SchoolManagement.DTO;
using System.Data.SqlClient;

namespace SchoolManagement.GUI
{
    public partial class frmChangePass : Form
    {
        procBUS proc = new procBUS();
        public frmChangePass()
        {
            InitializeComponent();
        }
        private void tbnChange_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == txtRe.Text)
            {
                int code = proc.ChangePass(uCTaiKhoanGV.username, txtOld.Text, txtNew.Text);
                if (code == 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (code == 1)
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
