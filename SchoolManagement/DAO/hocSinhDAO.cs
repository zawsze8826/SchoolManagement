using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DTO;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagement.DAO
{
    internal class hocSinhDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Student.IdStudent, Student.NameStudent, Student.GenderStudent, Student.BirthdayStudent, Student.Class, Student.FolkStudent, Student.AddressStudent FROM Student, TimeTable where Student.Class = TimeTable.Class", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddStudent(hocSinhDTO stu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Student(NameStudent, GenderStudent, BirthdayStudent, Class, FolkStudent, AddressStudent) values (N'{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}')",stu.StudentName,stu.StudentGender, stu.StudentBirthDay,stu.Clas, stu.Folk, stu.StudentAddress);
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
        public bool UpdateStudent(hocSinhDTO stu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update Student set NameStudent = N'{0}',GenderStudent = N'{1}',BirthdayStudent = '{2}', CLass = '{3}', FolkStudent= N'{4}', AddressStudent = N'{5}' where IdStudent = '{6}'", stu.StudentName, stu.StudentGender, stu.StudentBirthDay, stu.Clas, stu.Folk, stu.StudentAddress, stu.StudentID);
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
        public bool DeleteStudent(hocSinhDTO stu)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from Student where IdStudent = '{0}'", stu.StudentID);
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

        public DataTable SearchStudent(string searchType, string value)
        {
            string SQL = "SELECT Student.IdStudent, Student.NameStudent, Student.GenderStudent, Student.BirthdayStudent, Student.Class, TimeTable.Class, Student.FolkStudent, Student.AddressStudent FROM Student, TimeTable where Student.Class = TimeTable.Class and "+ searchType+"='"+ value +"'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
}
