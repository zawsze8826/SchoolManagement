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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Teacher", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddTeacher(giaoVienDTO tea)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Teacher(IdTeacher, NameTeacher, GenderTeacher, BirthdayTeacher, IdSubjects, PhoneTeacher, SalaryTeacher, AddressTeacher) values ('{0}', N'{1}', N'{2}', '{3}', '{4}', '{5}','{6}', N'{7}')", tea.TeacherID, tea.TeacherName, tea.TeacherGender, tea.TeacherBirthday, tea.Subject, tea.PhoneNum ,tea.Salary, tea.TeacherAddress);
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
                string SQL = string.Format("update Teacher set NameTeacher = N'{0}',GenderTeacher = N'{1}',BirthdayTeaCher = '{2}', SubjectOfTeacher = N'{3}', PhoneTeacher= '{4}', SalaryTeacher = '{5}', AddressTeacher = N'{6}' where IdTeacher = '{7}'", tea.TeacherName, tea.TeacherGender, tea.TeacherBirthday, tea.Subject, tea.PhoneNum, tea.Salary, tea.TeacherAddress, tea.TeacherID);
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
            string SQL = string.Format("select * from Teacher where {0} like '{1}'", searchType, value);
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
}
