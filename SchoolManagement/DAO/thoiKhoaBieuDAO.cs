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
            SqlCommand cmd = new SqlCommand("SELECT Teaching.Class,DATENAME(w,Teaching.DayToLearn) as Thu, Teaching.TimeToLearn, Teacher.IdTeacher ,Teacher.NameTeacher, Subjects.NameSubjects from Teaching, Teacher, Subjects where Teacher.IdTeacher = Teaching.IdTeacher and Subjects.IdSubjects = Teacher.IdSubjects ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadClass()
        {
            SqlCommand cmd = new SqlCommand("SELECT TimeTable.Class from TimeTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable XemButton(string value)
        {
            string cmd = "SELECT Teaching.Class, DateName(w,Teaching.DayToLearn) as Thu, Teaching.TimeToLearn, Teaching.IdTeacher , Teacher.NameTeacher, Subjects.NameSubjects from Teaching, Teacher, Subjects, TimeTable Where Teacher.IdTeacher = Teaching.IdTeacher and Subjects.IdSubjects = Teacher.IdSubjects and TimeTable.Class = Teaching.Class and  TimeTable.Class = '" + value +"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }
    }
}
