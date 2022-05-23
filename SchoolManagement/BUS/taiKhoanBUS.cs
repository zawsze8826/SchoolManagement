using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DAO;
using SchoolManagement.DTO;
using System.Data;

namespace SchoolManagement.BUS
{
    internal class taiKhoanBUS
    {
        taiKhoanDAO daoTaiKhoan = new taiKhoanDAO();

        public DataTable LoadData()
        {
            return daoTaiKhoan.LoadData();
        }

        public bool AddAcc(taiKhoanDTO tk)
        {
            return daoTaiKhoan.AddAcc(tk);
        }

        public bool UpdateAcc(taiKhoanDTO tk)
        {
            return daoTaiKhoan.UpdateAcc(tk);
        }

        public bool DeleteAcc(taiKhoanDTO tk)
        {
            return daoTaiKhoan.DeleteAcc(tk);
        }
    }
}
