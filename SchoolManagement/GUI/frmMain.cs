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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void TSMIGiaoVien_Click(object sender, EventArgs e)
        {
            uCGiaoVien gv = new uCGiaoVien();
            panel1.Controls.Clear();
            panel1.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void TSMIHocSinh_Click(object sender, EventArgs e)
        {
            uCHocSinh hs = new uCHocSinh();
            panel1.Controls.Clear();
            panel1.Controls.Add(hs);
            hs.Dock = DockStyle.Fill;
        }

        private void TSMITaiKhoan_Click(object sender, EventArgs e)
        {
            uCTaiKhoan tk = new uCTaiKhoan();
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

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uCLop gd = new uCLop();
            panel1.Controls.Clear();
            panel1.Controls.Add(gd);
            gd.Dock = DockStyle.Fill;
        }

        private void TSMIMonHoc_Click(object sender, EventArgs e)
        {
            uCMonHoc gd = new uCMonHoc();
            panel1.Controls.Clear();
            panel1.Controls.Add(gd);
            gd.Dock = DockStyle.Fill;
        }
    }
}
