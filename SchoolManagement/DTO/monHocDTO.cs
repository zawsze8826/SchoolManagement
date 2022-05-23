using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    internal class monHocDTO
    {
        private string idSubjects;
        private string nameSubjects;

        public monHocDTO(string idSubjects, string nameSubjects)
        {
            IdSubjects = idSubjects;
            NameSubjects = nameSubjects;
        }

        public string IdSubjects { get => idSubjects; set => idSubjects = value; }
        public string NameSubjects { get => nameSubjects; set => nameSubjects = value; }
    }
}
