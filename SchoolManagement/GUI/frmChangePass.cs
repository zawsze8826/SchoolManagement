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
        taiKhoanGVBUS busTaiKhoanGV = new taiKhoanGVBUS();
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void tbnChange_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8G9CDET;Initial Catalog=HighSchool;Integrated Security=True");
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ChangePass";
                cmd.Parameters.AddWithValue("@UserName", uCTaiKhoanGV.username);
                cmd.Parameters.AddWithValue("@OldPassword", txtOld.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtNew.Text);
                cmd.Connection = conn;
                if (txtNew.Text == txtRe.Text)
                {
                    object kq = cmd.ExecuteScalar();
                    int code = Convert.ToInt32(kq);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
