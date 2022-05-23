using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class lopDTO
    {
        private string nameClass;
        private string schoolYear;

        public lopDTO(string nameClass, string schoolYear)
        {
            NameClass = nameClass;
            SchoolYear = schoolYear;
        }
        public string NameClass { get => nameClass; set => nameClass = value; }
        public string SchoolYear { get => schoolYear; set => schoolYear = value; }
    }
}
