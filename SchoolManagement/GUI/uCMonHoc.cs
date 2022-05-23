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
    public partial class uCMonHoc : UserControl
    {
        monHocBUS busMonHoc = new monHocBUS();
        public uCMonHoc()
        {
            InitializeComponent();
            dGV.DataSource = busMonHoc.LoadData();
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dGV.Rows[e.RowIndex];
            txtIdMon.Text = row.Cells[0].Value.ToString();
            txtTenMon.Text = row.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            monHocDTO mon = new monHocDTO(txtIdMon.Text, txtTenMon.Text);
            busMonHoc.AddSubjects(mon);
            dGV.DataSource = busMonHoc.LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            monHocDTO mon = new monHocDTO(txtIdMon.Text, txtTenMon.Text);
            busMonHoc.UpdateSubjects(mon);
            dGV.DataSource = busMonHoc.LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            monHocDTO mon = new monHocDTO(txtIdMon.Text, txtTenMon.Text);
            busMonHoc.DeleteSubjects(mon);
            dGV.DataSource = busMonHoc.LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busMonHoc.LoadData();
        }
    }
}
