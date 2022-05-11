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
using SchoolManagement.DTO;

namespace SchoolManagement.GUI
{
    public partial class uCGiaoVien : UserControl
    {
        giaoVienBUS busTeacher = new giaoVienBUS();
        public uCGiaoVien()
        {
            InitializeComponent();
            dGV.DataSource = busTeacher.LoadData();
        }

        private void tsmRefreshTC_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busTeacher.LoadData();
        }

        private void btnUpdateTC_Click(object sender, EventArgs e)
        {
            giaoVienDTO tea = new giaoVienDTO(txtMaGV.Text, txtTen.Text, cbbGT.Text, dtpNgaySinh.Text, txtTenMon.Text, txtSDT.Text, txtLuong.Text, txtDiaChi.Text);
            busTeacher.UpdateTeacher(tea);
            dGV.DataSource = busTeacher.LoadData();
        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentRow.Index;
            txtMaGV.Text = dGV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
            cbbGT.Text = dGV.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dGV.Rows[i].Cells[3].Value.ToString();
            txtTenMon.Text = dGV.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dGV.Rows[i].Cells[5].Value.ToString();
            txtLuong.Text = dGV.Rows[i].Cells[6].Value.ToString();
            txtDiaChi.Text = dGV.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAddTC_Click(object sender, EventArgs e)
        {
            giaoVienDTO tea = new giaoVienDTO(txtMaGV.Text, txtTen.Text, cbbGT.Text, dtpNgaySinh.Text, txtTenMon.Text, txtSDT.Text, txtLuong.Text, txtDiaChi.Text);
            busTeacher.AddTeacher(tea);
            dGV.DataSource = busTeacher.LoadData();
        }

        private void btnDeleteTC_Click(object sender, EventArgs e)
        {
            giaoVienDTO tea = new giaoVienDTO(txtMaGV.Text, txtTen.Text, cbbGT.Text, dtpNgaySinh.Text, txtTenMon.Text, txtSDT.Text, txtLuong.Text, txtDiaChi.Text);
            busTeacher.DeleteTeacher(tea);
            dGV.DataSource = busTeacher.LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchType;
            if (cboSearchType.Text == "Mã Giáo Viên") searchType = "IdTeacher";
            else if (cboSearchType.Text == "Tên") searchType = "NameTeacher";
            else searchType = "PhoneTeacher";
            dGV.DataSource = busTeacher.SearchTeacher(searchType, txtTimKiem.Text);
        }
    }
}
