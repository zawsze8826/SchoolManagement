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
            SqlCommand cmd = new SqlCommand("SELECT Teaching.IdTeacher, Teacher.NameTeacher, Teaching.IdClass, TimeTable.Class, Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.IdClass = TimeTable.IdClass", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataGiaoVien()
        {
            SqlCommand cmd = new SqlCommand("select * from Teacher", conn);
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
            string cm = "SELECT Teaching.IdTeacher, Teacher.NameTeacher, TimeTable.Class, Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.IdClass = TimeTable.IdClass and TimeTable.Class = '" + value + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }


        public DataTable LoadDataXemGiaoVien(string value)
        {
            string cm = "SELECT Teaching.IdTeacher, Teacher.NameTeacher, TimeTable.Class, Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.IdClass = TimeTable.IdClass and Teacher.IdTeacher = '" + value + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataXemThu(string value)
        {
            string cm = "SELECT Teaching.IdTeacher, Teacher.NameTeacher, TimeTable.Class ,Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w,DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.IdClass = TimeTable.IdClass and DATENAME(w,DayToLearn) = ' " + value + " ' ";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }
    }
}
