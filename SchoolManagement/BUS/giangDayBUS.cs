using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DAO;
using System.Data;


namespace SchoolManagement.BUS
{
    internal class giangDayBUS
    {
        giangDayDAO daoGiangDay= new giangDayDAO();
        
            
        public DataTable LoadData()
        {
            //DataView dvLop = new DataView();
            //DataView dvThu = new DataView();
            //DataView dvXGiaoVien = new DataView();
            //DataView dvXLop = new DataView();
            //DataView dvXThu = new DataView();
            return daoGiangDay.LoadDataDGV();
        }

        public DataTable LoadDataGiaoVien()
        {
            return daoGiangDay.LoadDataGiaoVien();
        }

        public DataTable LoadDataLop()
        {
            return daoGiangDay.LoadDataLop();
        }

        public DataTable LoadDataXemLop(string value)
        {
            return daoGiangDay.LoadDataXemLop(value);
        }

        public DataTable LoadDataXemGiaoVien(string value)
        {
            return daoGiangDay.LoadDataXemGiaoVien(value);
        }

        public DataTable LoadDataXemThu(string value)
        {
            return daoGiangDay.LoadDataXemThu(value);
        }
    }
}
