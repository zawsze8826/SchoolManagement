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
    internal class monHocDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From Subjects", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool AddSubjects(monHocDTO mon)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into Subjects(NameSubjects) values (N'{1}')",mon.NameSubjects);
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
        public bool UpdateSubjects(monHocDTO mon)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update Subjects set NameSubjects = '{0}' where IdSubjects = '{1}'", mon.NameSubjects, mon.IdSubjects);
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
        public bool DeleteSubjects(monHocDTO mon)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from Subjects where IdSubjects = '{0}'", mon.IdSubjects);
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
