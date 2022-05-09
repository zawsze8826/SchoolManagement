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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            uCGiaoVien gv = new uCGiaoVien();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            uCHocSinh hs = new uCHocSinh();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(hs);
            hs.Dock = DockStyle.Fill;
        }

        private void btnGiangDay_Click(object sender, EventArgs e)
        {
            uCGiangDay gd = new uCGiangDay();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(gd);
            gd.Dock = DockStyle.Fill;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            uCTaiKhoan tk = new uCTaiKhoan();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(tk);
            tk.Dock = DockStyle.Fill;
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            uCThoiKhoaBieu tks = new uCThoiKhoaBieu();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(tks);
            tks.Dock = DockStyle.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fLogin newLogin = new fLogin();
            this.Hide();
            newLogin.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
