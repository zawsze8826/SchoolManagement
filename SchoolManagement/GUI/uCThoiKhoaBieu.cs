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
    public partial class uCThoiKhoaBieu : UserControl
    {
        thoiKhoaBieuBUS busThoiKhoaBieu = new thoiKhoaBieuBUS();

        public uCThoiKhoaBieu()
        {
            InitializeComponent();
            dGV.DataSource = busThoiKhoaBieu.LoadData();
            cboClass.DataSource = busThoiKhoaBieu.LoadClass();
            cboClass.DisplayMember = "CLass";
            cboClass.ValueMember = "Class";
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGV.DataSource = busThoiKhoaBieu.XemButton(cboClass.SelectedValue.ToString());
        }
    }
}
