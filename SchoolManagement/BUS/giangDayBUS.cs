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
    internal class giangDayBUS
    {
        giangDayDAO daoGiangDay= new giangDayDAO();
        public DataTable LoadData()
        {
            return daoGiangDay.LoadDataDGV();
        }
        public DataTable LoadDataLop()
        {
            return daoGiangDay.LoadDataLop();
        }

        public DataTable LoadDataXemLop(string value)
        {
            return daoGiangDay.LoadDataXemLop(value);
        }

    }
}
