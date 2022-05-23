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
    public partial class uCGiangDay : UserControl
    {
        giangDayBUS busGiangDay = new giangDayBUS();

        public uCGiangDay()
        {
            InitializeComponent();
            DataView dataView = new DataView(busGiangDay.LoadData());

            dGV.DataSource = dataView;

            DataView dvXemLop = new DataView(busGiangDay.LoadDataLop());
            cboXemLop.DataSource = dvXemLop;
            cboXemLop.DisplayMember = "Class";
            cboXemLop.ValueMember = "Class";
        }

        private void cboXemLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV.DataSource = busGiangDay.LoadDataXemLop(Convert.ToString(cboXemLop.SelectedValue));
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dGV.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtGiaoVien.Text = row.Cells[2].Value.ToString();
            txtLop.Text = row.Cells[3].Value.ToString();
            txtThu.Text = row.Cells[6].Value.ToString();
            txtTiet.Text = row.Cells[7].Value.ToString();
        }

    }
}
