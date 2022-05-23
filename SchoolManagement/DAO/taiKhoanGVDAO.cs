using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.GUI;
using System.Data.SqlClient;
using System.Data;

namespace SchoolManagement.DAO
{
    internal class taiKhoanGVDAO : DBConnect
    {
        public DataTable LoadDataGV()
        {
            string cm = "SELECT * From Teacher Where IdTeacher = '" + fLogin.id + "'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable LoadDataTK()
        {
            string cm = "SELECT * From Acc where Username = '"+ fLogin.userName +"'";
            SqlCommand cmd = new SqlCommand(cm, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table = new DataTable();
            da.Fill(Table);
            return Table;
        }
    }
}
