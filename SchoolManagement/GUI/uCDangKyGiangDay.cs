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
    public partial class uCDangKyGiangDay : UserControl
    {
         dangKyGiangDayBUS busDangKy = new dangKyGiangDayBUS();

        public uCDangKyGiangDay()
        {
            InitializeComponent();
            dGV.DataSource = busDangKy.LoadDataAll();

            DataView dvXemLop = new DataView(busDangKy.LoadDataLop());
            cboXemLop.DataSource = dvXemLop;
            cboXemLop.ValueMember = "Class";

            DataView dvLop = new DataView(busDangKy.LoadDataLop1());
            cboLop.DataSource = dvLop;
            cboLop.ValueMember = "Class";
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dGV.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtIdTeacher.Text = row.Cells[1].Value.ToString();
            txtGiaoVien.Text = row.Cells[2].Value.ToString();
            cboLop.Text = row.Cells[3].Value.ToString();
            dTP.Text = row.Cells[5].Value.ToString();
            cboTiet.Text = row.Cells[7].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busDangKy.LoadDataXemLop(cboXemLop.Text);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busDangKy.LoadDataAll();
        }

        private void dTP_ValueChanged(object sender, EventArgs e)
        {
            DataView dvLop = new DataView(busDangKy.LoadDataTiet(cboLop.SelectedValue.ToString(),dTP.Value.ToString()));
            cboTiet.DataSource = dvLop;
            cboTiet.ValueMember = "TimeToLearn";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            dangKyGiangDayDTO dk = new dangKyGiangDayDTO(txtId.Text,txtIdTeacher.Text,txtGiaoVien.Text, cboLop.Text, dTP.Text, cboTiet.Text);
            busDangKy.DangKy(dk);
            dGV.DataSource = busDangKy.LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dangKyGiangDayDTO dk = new dangKyGiangDayDTO(txtId.Text, txtIdTeacher.Text, txtGiaoVien.Text, cboLop.Text, dTP.Text, cboTiet.Text);
            busDangKy.Update(dk);
            dGV.DataSource = busDangKy.LoadData();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dangKyGiangDayDTO dk = new dangKyGiangDayDTO(txtId.Text, txtIdTeacher.Text, txtGiaoVien.Text, cboLop.Text, dTP.Text, cboTiet.Text);
            busDangKy.Delete(dk);
            dGV.DataSource = busDangKy.LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dGV.DataSource = busDangKy.LoadData();
        }
    }
}
