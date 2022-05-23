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
    internal class monHocBUS
    {
        monHocDAO daoMon = new monHocDAO();

        public DataTable LoadData()
        {
            return daoMon.LoadData();
        }

        //public DataTable LoadDataXemKhoa(string value)
        //{
        //    return daoMon.LoadDataXemKhoa(value);
        //}

        //public DataTable LoadDataKhoa()
        //{
        //    return daoMon.LoadDataKhoa();
        //}

        public bool AddSubjects(monHocDTO mon)
        {
            return daoMon.AddSubjects(mon);
        }

        public bool UpdateSubjects(monHocDTO mon)
        {
            return daoMon.UpdateSubjects(mon);
        }

        public bool DeleteSubjects(monHocDTO mon)
        {
            return daoMon.DeleteSubjects(mon);
        }
    }
}
