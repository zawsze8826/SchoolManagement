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
    public partial class uCTaiKhoan : UserControl
    {
        taiKhoanBUS busTaiKhoan = new taiKhoanBUS();
        public uCTaiKhoan()
        {
            InitializeComponent();
            dGV.DataSource = busTaiKhoan.LoadData();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dGV.Rows[e.RowIndex];
            txtUsername.Text = row.Cells[0].Value.ToString();
            txtPassword.Text = row.Cells[1].Value.ToString();
            txtLoaiTK.Text = row.Cells[2].Value.ToString();
        }

        private void ucThem_Click(object sender, EventArgs e)
        {
            taiKhoanDTO tk = new taiKhoanDTO(txtUsername.Text, txtPassword.Text, txtLoaiTK.Text);
            busTaiKhoan.AddAcc(tk);
            dGV.DataSource = busTaiKhoan.LoadData();
        }

        private void ucSua_Click(object sender, EventArgs e)
        {
            taiKhoanDTO tk = new taiKhoanDTO(txtUsername.Text, txtPassword.Text, txtLoaiTK.Text);
            busTaiKhoan.UpdateAcc(tk);
            dGV.DataSource = busTaiKhoan.LoadData();
        }

        private void ucXoa_Click(object sender, EventArgs e)
        {
            taiKhoanDTO tk = new taiKhoanDTO(txtUsername.Text, txtPassword.Text, txtLoaiTK.Text);
            busTaiKhoan.DeleteAcc(tk);
            dGV.DataSource = busTaiKhoan.LoadData();
        }

        private void ucRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busTaiKhoan.LoadData();
        }
    }
}
