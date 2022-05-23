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
    public partial class uCLop : UserControl
    {
        lopBUS busLop = new lopBUS();
        public uCLop()
        {
            InitializeComponent();
            DataView dataView = new DataView(busLop.LoadData());

            dGV.DataSource = dataView;

            DataView dataSchoolYear = new DataView(busLop.LoadDataKhoa());
            cboXemKhoa.DataSource = dataSchoolYear;
            cboXemKhoa.ValueMember = "SchoolYear";
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dGV.Rows[e.RowIndex];
            txtTenLop.Text = row.Cells[0].Value.ToString();
            txtNamHoc.Text = row.Cells[1].Value.ToString();;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busLop.LoadDataXemKhoa(cboXemKhoa.Text);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busLop.LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lopDTO l = new lopDTO(txtTenLop.Text, txtNamHoc.Text);
            busLop.AddClass(l);
            dGV.DataSource = busLop.LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lopDTO l = new lopDTO(txtTenLop.Text, txtNamHoc.Text);
            busLop.UpdateClass(l);
            dGV.DataSource = busLop.LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lopDTO l = new lopDTO(txtTenLop.Text, txtNamHoc.Text);
            busLop.DeleteClass(l);
            dGV.DataSource = busLop.LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busLop.LoadData();
        }
    }

}
