using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class giaoVienDTO
    {
        private string teacherID;
        private string teacherName;
        private string teacherGender;
        private string teacherBirthday;
        private string idSubject;
        private string phoneNum;
        private string salary;
        private string teacherAddress;

        public giaoVienDTO(string teacherID, string teacherName, string teacherGender, string teacherBirthday, string subject, string phoneNum, string salary, string teacherAddress)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
            TeacherGender = teacherGender;
            TeacherBirthday = teacherBirthday;
            IdSubject = subject;
            PhoneNum = phoneNum;
            Salary = salary;
            TeacherAddress = teacherAddress;
        }

        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string TeacherGender { get => teacherGender; set => teacherGender = value; }
        public string TeacherBirthday { get => teacherBirthday; set => teacherBirthday = value; }
        public string IdSubject { get => idSubject; set => idSubject = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Salary { get => salary; set => salary = value; }
        public string TeacherAddress { get => teacherAddress; set => teacherAddress = value; }
    }
}
