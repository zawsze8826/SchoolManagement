using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class hocSinhDTO
    {
        private string studentID;
        private string studentName;
        private string studentGender;
        private string studentBirthDay;
        private string clas;
        private string folk;
        private string studentAddress;

        public string StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentGender { get => studentGender; set => studentGender = value; }
        public string StudentBirthDay { get => studentBirthDay; set => studentBirthDay = value; }
        public string Clas { get => clas; set => clas = value; }
        public string Folk { get => folk; set => folk = value; }
        public string StudentAddress { get => studentAddress; set => studentAddress = value; }

        public hocSinhDTO(string studentID, string studentName, string gender, string birthDay, string clas, string folk, string address)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentGender = gender;
            StudentBirthDay = birthDay;
            Clas = clas;
            Folk = folk;
            StudentAddress = address;
        }
    }
}
