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
    internal class giaoVienBUS
    {
        giaoVienDAO daoTeacher = new giaoVienDAO();
        public DataTable LoadData()
        {
            return daoTeacher.LoadData();
        }
        public bool AddTeacher(giaoVienDTO tea)
        {
            return daoTeacher.AddTeacher(tea);
        }
        public bool UpdateTeacher(giaoVienDTO tea)
        {
            return daoTeacher.UpdateTeacher(tea);
        }
        public bool DeleteTeacher(giaoVienDTO tea)
        {
            return daoTeacher.DeleteTeacher(tea);
        }
        public DataTable SearchTeacher(string searchType, string value)
        {
            return daoTeacher.SearchTeacher(searchType, value);
        }
    }
}
