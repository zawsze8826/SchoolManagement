using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DAO
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=DESKTOP-8G9CDET;Initial Catalog=HighSchool;Integrated Security=True");
    }
}
