using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagement.DAO
{
    internal class procDAO : DBConnect
    {
        public int ChangePass(string username, string oldPass, string newPass)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ChangePass";
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@OldPassword", oldPass);
            cmd.Parameters.AddWithValue("@NewPassword", newPass);
            cmd.Connection = conn;
            object kq = cmd.ExecuteScalar();
            conn.Close();
            return Convert.ToInt32(kq);
        }

        public int Login(string username, string password)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_AuthoLogin";
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Connection = conn;
            cmd.ExecuteScalar();
            object kq = cmd.ExecuteScalar();
            conn.Close();
            return Convert.ToInt32(kq);
        }
    }
}
