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
    internal class lopDAO : DBConnect
    {
        public DataTable LoadData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * From TimeTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataKhoa()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT SchoolYear From TimeTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public DataTable LoadDataXemKhoa(string value)
        {
            string cm = "SELECT* From TimeTable where SchoolYear = '" + value + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable talbe = new DataTable();
            da.Fill(talbe);
            return talbe;
        }

        public bool AddCLass(lopDTO l )
        {
            try
            {
                conn.Open();
                string SQL = string.Format("insert into TimeTable(Class, SchoolYear) values ('{0}', '{1}')",l.NameClass, l.SchoolYear);
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

        public bool UpdateClass(lopDTO l)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("update TimeTable set SchoolYear = '{0}' where CLass = '{1}'",  l.SchoolYear, l.NameClass);
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

        public bool DeleteClass(lopDTO l)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("delete from TimeTable where Class = '{0}'", l.NameClass);
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
