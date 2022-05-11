using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DAO;
using System.Data;

namespace SchoolManagement.BUS
{
    internal class thoiKhoaBieuBUS
    {
        thoiKhoaBieuDAO daoThoiKhoaBieu = new thoiKhoaBieuDAO();
        public DataTable LoadData()
        {
            return daoThoiKhoaBieu.LoadData();
        }
        public DataTable LoadClass()
        {
            return daoThoiKhoaBieu.LoadClass();
        }

        public DataTable XemButton(string value)
        {
            return daoThoiKhoaBieu.XemButton(value);
        }
    }
}
