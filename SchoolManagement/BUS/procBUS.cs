using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.DAO;
using SchoolManagement.DTO;
using System.Data;

namespace SchoolManagement.BUS
{
    internal class procBUS
    {
        procDAO proc = new procDAO();
        public int ChangePass(string username, string oldPass, string newPass)
        {
            return proc.ChangePass(username, oldPass, newPass);
        }

        public int Login(string username, string password)
        {
            return proc.Login(username, password);
        }
    }
}
