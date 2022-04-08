using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public string name { get; set; }
        public string middleName { get; set; }
        public string familyName { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string educationalDegree { get; set; }
        public string status { get; set; }
        public string facultyNumber { get; set; }
        public int course { get; set; }
        public int stream { get; set; } //Поток
        public int group { get; set; }
    }
}
