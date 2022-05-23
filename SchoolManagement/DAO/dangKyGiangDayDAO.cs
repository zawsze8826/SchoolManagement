using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SchoolManagement.DTO;
using SchoolManagement.GUI;

namespace SchoolManagement.DAO
{
    internal class dangKyGiangDayDAO : DBConnect
    {
        public DataTable LoadData()
        {
            string cm = "SELECT Teaching.IdTeaching, Teaching.IdTeacher , Teacher.NameTeacher, TimeTable.Class ,Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.Class = TimeTable.Class and Teaching.IdTeacher = '" + fLogin.id + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataAll()
        {
            string cm = "SELECT Teaching.IdTeaching, Teaching.IdTeacher , Teacher.NameTeacher, TimeTable.Class ,Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.Class = TimeTable.Class";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataLop()
        {
            string cm = "SELECT * From TimeTable";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataXemLop(string value)
        {
            string cm = "SELECT Teaching.IdTeaching, Teaching.IdTeacher , Teacher.NameTeacher, TimeTable.Class ,Subjects.NameSubjects, Teaching.DayToLearn, DATENAME(w, DayToLearn) as Thu, Teaching.TimeToLearn From Teaching, Teacher, Subjects, TimeTable Where Teaching.IdTeacher = Teacher.IdTeacher and Teacher.IdSubjects = Subjects.IdSubjects and Teaching.Class = TimeTable.Class and Teaching.IdTeacher = '" + fLogin.id + "' and TimeTable.Class = '" + value + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataLop1()
        {
            string cm = "SELECT * From TimeTable";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataTiet(string clas, string dayToLearn)
        {
            string cm = "SELECT DayToLearn, TimeToLearn FROM Tiet  where DayToLearn = '"+ dayToLearn +"'  EXCEPT SELECT DayToLearn, TimeToLearn FROM Teaching where CLass = '"+ clas +"' and DayToLearn = '"+ dayToLearn +"'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public bool DangKy(dangKyGiangDayDTO dk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Teaching(IdTeacher, Class, DayToLearn, TimeToLearn) values ('{0}', '{1}', '{2}', '{3}')", dk.IdTeacher, dk.Clas, dk.DayToLearn, dk.TimeToLearn);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Update(dangKyGiangDayDTO dk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update Teaching set IdTeacher = '{0}',Class = '{1}',DayToLearn = '{2}', TimeToLearn = '{3}' where IdTeaching = '{4}'", dk.IdTeacher, dk.Clas, dk.DayToLearn, dk.TimeToLearn, dk.IdTeaching);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool Delete(dangKyGiangDayDTO dk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from Teaching where IdTeaching = '{0}'", dk.IdTeaching);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
