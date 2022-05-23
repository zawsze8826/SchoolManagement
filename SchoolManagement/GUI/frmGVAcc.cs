using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.GUI
{
    public partial class frmGVAcc : Form
    {
        public frmGVAcc()
        {
            InitializeComponent();
        }

        private void TSMIThongTinGiaoViean_Click(object sender, EventArgs e)
        {
            uCThongTinGiaoVien gv = new uCThongTinGiaoVien();
            panel1.Controls.Clear();
            panel1.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void TSMITaiKhoan_Click(object sender, EventArgs e)
        {
            uCTaiKhoanGV tk = new uCTaiKhoanGV();
            panel1.Controls.Clear();
            panel1.Controls.Add(tk);
            tk.Dock = DockStyle.Fill;
        }

        private void TSMIThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            uCThoiKhoaBieu tks = new uCThoiKhoaBieu();
            panel1.Controls.Clear();
            panel1.Controls.Add(tks);
            tks.Dock = DockStyle.Fill;
        }

        private void TSMILichGiangDay_Click(object sender, EventArgs e)
        {
            uCGiangDay gd = new uCGiangDay();
            panel1.Controls.Clear();
            panel1.Controls.Add(gd);
            gd.Dock = DockStyle.Fill;
        }

        private void TSMIDangKyGiangDay_Click(object sender, EventArgs e)
        {
            uCDangKyGiangDay gd = new uCDangKyGiangDay();
            panel1.Controls.Clear();
            panel1.Controls.Add(gd);
            gd.Dock = DockStyle.Fill;
        }
    }
}
