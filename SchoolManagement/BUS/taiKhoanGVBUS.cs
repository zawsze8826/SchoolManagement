using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DTO;
using SchoolManagement.DAO;
using System.Data;


namespace SchoolManagement.BUS
{
    
    internal class taiKhoanGVBUS
    {
        taiKhoanGVDAO daoTaiKhoanGV = new taiKhoanGVDAO();
        public DataTable LoadDataGV()
        {
            return daoTaiKhoanGV.LoadDataGV();
        }
        public DataTable LoadDataTK()
        {
            return daoTaiKhoanGV.LoadDataTK();
        }
    }
}
