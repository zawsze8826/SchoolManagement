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
    internal class giaoVienDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Teacher.IdTeacher, Teacher.NameTeacher, Teacher.GenderTeacher, Teacher.BirthdayTeacher, Teacher.IdSubjects, Subjects.NameSubjects, Teacher.PhoneTeacher, Teacher.SalaryTeacher, Teacher.AddressTeacher From Teacher, Subjects Where Teacher.IdSubjects = Subjects.IdSubjects", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddTeacher(giaoVienDTO tea)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Teacher(NameTeacher, GenderTeacher, BirthdayTeacher, IdSubjects, PhoneTeacher, SalaryTeacher, AddressTeacher) values ('N{0}', N'{1}', '{2}', '{3}', '{4}', '{5}' ,N'{6}')", tea.TeacherName, tea.TeacherGender, tea.TeacherBirthday, tea.IdSubject, tea.PhoneNum ,tea.Salary, tea.TeacherAddress);
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
        public bool UpdateTeacher(giaoVienDTO tea)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update Teacher set NameTeacher = N'{0}',GenderTeacher = N'{1}',BirthdayTeaCher = '{2}', IdSubjects = '{3}', PhoneTeacher= '{4}', SalaryTeacher = '{5}', AddressTeacher = N'{6}' where IdTeacher = '{7}'", tea.TeacherName, tea.TeacherGender, tea.TeacherBirthday, tea.IdSubject, tea.PhoneNum, tea.Salary, tea.TeacherAddress, tea.TeacherID);
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
        public bool DeleteTeacher(giaoVienDTO tea)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from Teacher where IdTeacher = '{0}'", tea.TeacherID);
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
        public DataTable SearchTeacher(string searchType, string value)
        {
            string SQL = string.Format("SELECT Teacher.IdTeacher, Teacher.NameTeacher, Teacher.GenderTeacher, Teacher.BirthdayTeacher, Teacher.IdSubjects, Subjects.NameSubjects, Teacher.PhoneTeacher, Teacher.SalaryTeacher, Teacher.AddressTeacher From Teacher, Subjects Where Teacher.IdSubjects = Subjects.IdSubjects and {0} = '{1}'", searchType, value);
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
}
