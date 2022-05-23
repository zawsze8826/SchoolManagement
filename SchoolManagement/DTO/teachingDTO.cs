using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class teachingDTO
    {
        private string idTeaching;
        private string idTeacher;
        private string idClass;
        private string dayToLearn;
        private string timeToLearn;


        public string IdTeaching { get => idTeaching; set => idTeaching = value; }
        public string IdTeacher { get => idTeacher; set => idTeacher = value; }
        public string IdClass { get => idClass; set => idClass = value; }
        public string TimeToLearn { get => timeToLearn; set => timeToLearn = value; }
        public string DayToLearn { get => dayToLearn; set => dayToLearn = value; }

        public teachingDTO(string idTeaching, string idTeacher, string idClass, string dayToLearn,string timeToLearn)
        {
            IdTeaching = idTeaching;
            IdTeacher = idTeacher;
            IdClass = idClass;
            DayToLearn = dayToLearn;
            TimeToLearn = timeToLearn;
        }
    }
}
