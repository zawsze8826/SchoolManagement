using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class taiKhoanDTO
    {
        private string username;
        private string pass;
        private string typeAcc;

        public taiKhoanDTO(string username, string pass, string typeAcc)
        {
            Username = username;
            Pass = pass;
            TypeAcc = typeAcc;
        }

        public string Username { get => username; set => username = value; }
        public string Pass { get => pass; set => pass = value; }
        public string TypeAcc { get => typeAcc; set => typeAcc = value; }
    }
}
