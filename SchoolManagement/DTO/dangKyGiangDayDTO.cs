using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class dangKyGiangDayDTO
    {
        private string idTeaching;
        private string idTeacher;
        private string teacherName;
        private string clas;
        private string dayToLearn;
        private string timeToLearn;
        public dangKyGiangDayDTO(string idTeaching, string idTeacher, string teacherName, string clas, string dayToLearn, string timeToLearn)
        {
            IdTeaching = idTeaching;
            IdTeacher = idTeacher;
            TeacherName = teacherName;
            Clas = clas;
            DayToLearn = dayToLearn;
            TimeToLearn = timeToLearn;
        }

        public string IdTeaching { get => idTeaching; set => idTeaching = value; }
        public string IdTeacher { get => idTeacher; set => idTeacher = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string Clas { get => clas; set => clas = value; }
        public string DayToLearn { get => dayToLearn; set => dayToLearn = value; }
        public string TimeToLearn { get => timeToLearn; set => timeToLearn = value; }


    }
}
