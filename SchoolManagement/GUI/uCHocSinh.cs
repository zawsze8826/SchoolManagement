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
    public partial class uCHocSinh : UserControl
    {
        hocSinhBUS busStudent = new hocSinhBUS();
        public uCHocSinh()
        {
            InitializeComponent();
            dGV.DataSource = busStudent.LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busStudent.LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            hocSinhDTO stu = new hocSinhDTO(txtMaHS.Text, txtTenHS.Text, cbbGT.Text, dtpNgaySinh.Text, txtLop.Text, txtDT.Text, txtDC.Text);
            busStudent.AddStudent(stu);
            dGV.DataSource = busStudent.LoadData();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            hocSinhDTO stu = new hocSinhDTO(txtMaHS.Text, txtTenHS.Text, cbbGT.Text, dtpNgaySinh.Text, txtLop.Text, txtDT.Text, txtDC.Text);
            busStudent.UpdateStudent(stu);
            dGV.DataSource = busStudent.LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hocSinhDTO stu = new hocSinhDTO(txtMaHS.Text, txtTenHS.Text, cbbGT.Text, dtpNgaySinh.Text, txtLop.Text, txtDT.Text, txtDC.Text);
            busStudent.DeleteStudent(stu);
            dGV.DataSource = busStudent.LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchType;
            if (cboTimkiem.Text == "Mã Học Sinh") searchType = "IdStudent";
            else if (cboTimkiem.Text == "Tên Học Sinh") searchType = "NameStudent";
            else if (cboTimkiem.Text == "Mã Lớp") searchType = "Student.IdClass";
            else if (cboTimkiem.Text == "Dân Tộc") searchType = "FolkStudent";
            else searchType = "AddressStudent";
            dGV.DataSource =  busStudent.SearchStudent(searchType, txtTimKiem.Text);
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentRow.Index;
            txtMaHS.Text = dGV.Rows[i].Cells[0].Value.ToString();
            txtTenHS.Text = dGV.Rows[i].Cells[1].Value.ToString();
            cbbGT.Text = dGV.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Text = dGV.Rows[i].Cells[3].Value.ToString();
            txtLop.Text = dGV.Rows[i].Cells[4].Value.ToString();
            txtDT.Text = dGV.Rows[i].Cells[5].Value.ToString();
            txtDC.Text = dGV.Rows[i].Cells[6].Value.ToString();
        }
    }
}
