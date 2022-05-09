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
    internal class hocSinhBUS
    {
        hocSinhDAO daoStudent = new hocSinhDAO();
        public DataTable LoadData()
        {
            return daoStudent.LoadData();
        }
        public bool AddStudent(hocSinhDTO stu)
        {
            return daoStudent.AddStudent(stu);
        }
        public bool UpdateStudent(hocSinhDTO stu)
        {
            return daoStudent.UpdateStudent(stu);
        }
        public bool DeleteStudent(hocSinhDTO stu)
        {
            return daoStudent.DeleteStudent(stu);
        }
        public DataTable SearchStudent(string searchType, string value)
        {
            return daoStudent.SearchStudent(searchType, value);
        }
    }
}
