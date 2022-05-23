using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SchoolManagement.DTO;

namespace SchoolManagement.DAO
{
    internal class giangDayDAO : DBConnect
    {
        
        public DataTable LoadDataDGV()
        {
            SqlCommand cmd = new SqlCommand("SELECT Teaching.IdTeaching, Teaching.IdTeacher , Teacher.NameTeacher, TimeTable.Class ,Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.Class = TimeTable.Class ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }


        public DataTable LoadDataLop()
        {
            SqlCommand cmd = new SqlCommand("select * from TimeTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataXemLop(string value)
        {
            string cm = "SELECT Teaching.IdTeaching, Teaching.IdTeacher, Teacher.NameTeacher, TimeTable.Class, Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.Class = TimeTable.Class and TimeTable.Class = '" + value + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }
    }
}
