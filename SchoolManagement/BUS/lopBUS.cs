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
    internal class lopBUS
    {
        lopDAO daoLop = new lopDAO();

        public DataTable LoadData()
        {
            return daoLop.LoadData();
        }

        public DataTable LoadDataXemKhoa(string value)
        {
            return daoLop.LoadDataXemKhoa(value);
        }

        public DataTable LoadDataKhoa()
        {
            return daoLop.LoadDataKhoa();
        }

        public bool AddClass(lopDTO l)
        {
            return daoLop.AddCLass(l);
        }

        public bool UpdateClass(lopDTO l)
        {
            return daoLop.UpdateClass(l);
        }

        public bool DeleteClass(lopDTO l)
        {
            return daoLop.DeleteClass(l);
        }
    }
}
