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

            DataView dvGiaoVien = new DataView(busGiangDay.LoadDataGiaoVien());
            //public DataView dvThu = new DataView();
            //public DataView dvXGiaoVien = new DataView();
            //public DataView dvXLop = new DataView();
            //public DataView dvXThu = new DataView();
            cboGiaoVien.DataSource = dvGiaoVien;
            cboGiaoVien.DisplayMember = "NameTeacher";
            cboGiaoVien.ValueMember = "IdTeacher";


            DataView dvLop = new DataView(busGiangDay.LoadDataLop());
            cboLop.DataSource = dvLop;
            cboLop.DisplayMember = "Class";
            cboLop.ValueMember = "CLass";

            cboThu.Text = "Monday";

            cboTiet.Text = "1";

            cboXemLop.DataSource = dvLop;
            cboXemLop.DisplayMember = "Class";
            cboXemLop.ValueMember = "Class";

            cboXemGiaoVien.DataSource = dvGiaoVien;
            cboXemGiaoVien.DisplayMember = "NameTeacher";
            cboXemGiaoVien.ValueMember = "IdTeacher";

        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGV.CurrentRow.Index;
            cboGiaoVien.Text = dGV.Rows[i].Cells[1].Value.ToString();
            cboLop.Text = dGV.Rows[i].Cells[2].Value.ToString();
            cboThu.Text = dGV.Rows[i].Cells[5].Value.ToString();
            cboTiet.Text = dGV.Rows[i].Cells[6].Value.ToString();

        }

        private void cboXemLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV.DataSource = busGiangDay.LoadDataXemLop(Convert.ToString(cboXemLop.SelectedValue));
        }

        private void cboXemGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV.DataSource = busGiangDay.LoadDataXemGiaoVien(Convert.ToString(cboXemGiaoVien.SelectedValue));
        }

        private void cboXemTheoThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV.DataSource = busGiangDay.LoadDataXemThu(Convert.ToString(cboXemTheoThu.SelectedValue));

        }
    }
}
