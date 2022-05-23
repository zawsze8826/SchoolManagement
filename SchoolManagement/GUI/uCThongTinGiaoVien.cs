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
    public partial class uCThongTinGiaoVien : UserControl
    {
        giaoVienBUS busTeacher = new giaoVienBUS();
        public uCThongTinGiaoVien()
        {
            InitializeComponent();
            dGV.DataSource = busTeacher.LoadData();
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentRow.Index;
            txtMaGV.Text = dGV.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dGV.Rows[i].Cells[1].Value.ToString();
            txtGt.Text = dGV.Rows[i].Cells[2].Value.ToString();
            txtNgaySinh.Text = dGV.Rows[i].Cells[3].Value.ToString();
            txtMaMon.Text = dGV.Rows[i].Cells[4].Value.ToString();
            txtTenMon.Text = dGV.Rows[i].Cells[5].Value.ToString();
            txtSDT.Text = dGV.Rows[i].Cells[6].Value.ToString();
            txtLuong.Text = dGV.Rows[i].Cells[7].Value.ToString();
            txtDiaChi.Text = dGV.Rows[i].Cells[8].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchType;
            if (cboSearchType.Text == "Mã Giáo Viên") searchType = "IdTeacher";
            else if (cboSearchType.Text == "Tên") searchType = "NameTeacher";
            else if (cboSearchType.Text == "Tên Môn") searchType = "Subjects.NameSubjects";
            else searchType = "PhoneTeacher";
            dGV.DataSource = busTeacher.SearchTeacher(searchType, txtTimKiem.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busTeacher.LoadData();
        }
    }
}
