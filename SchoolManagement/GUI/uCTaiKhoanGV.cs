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

namespace SchoolManagement.GUI
{
    public partial class uCTaiKhoanGV : UserControl
    {
        taiKhoanGVBUS busTaiKhoanGV = new taiKhoanGVBUS();
        public static string oldPass = "";
        public static string username = "";
        public uCTaiKhoanGV()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dGV.DataSource = busTaiKhoanGV.LoadDataGV();
            dGVTK.DataSource = busTaiKhoanGV.LoadDataTK();

            txtUsername.Text = dGVTK.Rows[0].Cells[0].Value.ToString();
            txtPassword.Text = dGVTK.Rows[0].Cells[1].Value.ToString();
            txtLoaiTK.Text = dGVTK.Rows[0].Cells[2].Value.ToString();

            txtID.Text = dGV.Rows[0].Cells[0].Value.ToString();
            txtName.Text = dGV.Rows[0].Cells[1].Value.ToString();
            txtGT.Text = dGV.Rows[0].Cells[2].Value.ToString();
            txtBirthDay.Text = dGV.Rows[0].Cells[3].Value.ToString();
            txtIdSub.Text = dGV.Rows[0].Cells[4].Value.ToString();
            txtPhoneNum.Text = dGV.Rows[0].Cells[5].Value.ToString();
            txtSalary.Text = dGV.Rows[0].Cells[6].Value.ToString();
            txtAddress.Text = dGV.Rows[0].Cells[7].Value.ToString();

            oldPass = txtPassword.Text;
            username = txtUsername.Text;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass newManage = new frmChangePass();
            newManage.ShowDialog();
            LoadData();
        }
    }
}
