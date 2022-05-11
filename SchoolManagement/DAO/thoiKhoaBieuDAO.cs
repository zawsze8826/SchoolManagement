using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SchoolManagement.DAO
{
    internal class thoiKhoaBieuDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT Teaching.IdClass,DATENAME(w,Teaching.DayToLearn) as Thu, Teaching.TimeToLearn, Teacher.NameTeacher, Subjects.NameSubjects from Teaching, Teacher, Subjects where Teacher.IdTeacher = Teaching.IdTeacher and Subjects.IdSubjects = Teacher.IdSubjects ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadClass()
        {
            SqlCommand cmd = new SqlCommand("SELECT TimeTable.IdClass, TimeTable.Class from TimeTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable XemButton(string value)
        {
            SqlCommand cmd = new SqlCommand("SELECT Teaching.IdClass,DATENAME(w,Teaching.DayToLearn) as Thu, Teaching.TimeToLearn, Teacher.NameTeacher, Subjects.NameSubjects from Teaching, Teacher, Subjects where Teacher.IdTeacher = Teaching.IdTeacher and Subjects.IdSubjects = Teacher.IdSubjects and Teaching.IdClass = '" + value +"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }
    }
}
