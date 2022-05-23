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
    internal class dangKyGiangDayBUS
    {
        dangKyGiangDayDAO daoDangKy = new dangKyGiangDayDAO();
        public DataTable LoadData()
        {
            return daoDangKy.LoadData();
        }

        public DataTable LoadDataAll()
        {
            return daoDangKy.LoadDataAll();
        }

        public DataTable LoadDataLop()
        {
            return daoDangKy.LoadDataLop();
        }

        public DataTable LoadDataXemLop(string value)
        {
            return daoDangKy.LoadDataXemLop(value);
        }

        public DataTable LoadDataLop1()
        {
            return daoDangKy.LoadDataLop1();
        }

        public DataTable LoadDataTiet(string id, string dayToLearn)
        {
            return daoDangKy.LoadDataTiet(id, dayToLearn);
        }

        public bool DangKy(dangKyGiangDayDTO dk)
        {
            return daoDangKy.DangKy(dk);
        }
        public bool Update(dangKyGiangDayDTO dk)
        {
            return daoDangKy.Update(dk);
        }
        public bool Delete(dangKyGiangDayDTO dk)
        {
            return daoDangKy.Delete(dk);
        }
    }
}
