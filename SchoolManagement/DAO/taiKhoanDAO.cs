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
    internal class taiKhoanDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Acc", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool AddAcc(taiKhoanDTO tk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Acc(Username, Pass, TypeAcc)  values ('{0}', '{1}', '{2}')",tk.Username, tk.Pass,tk.TypeAcc);
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

        public bool UpdateAcc(taiKhoanDTO tk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update Acc set Pass = '{0}',TypeAcc = '{1}' where Username = '{2}'",tk.Pass, tk.TypeAcc, tk.Username);
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

        public bool DeleteAcc(taiKhoanDTO tk)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from Acc where Username = '{0}'", tk.Username);
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
            string SQL = "SELECT Student.IdStudent, Student.NameStudent, Student.GenderStudent, Student.BirthdayStudent, Student.IdClass, TimeTable.Class, Student.FolkStudent, Student.AddressStudent FROM Student, TimeTable where Student.IdClass = TimeTable.IdClass and " + searchType + "='" + value + "'";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
    }
}
