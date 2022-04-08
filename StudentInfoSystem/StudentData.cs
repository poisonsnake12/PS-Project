using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        private static List<Student> _testStudents;

        public static List<Student> TestStudents
        {
            get
            {
                ResetTestStudentsData();
                return _testStudents;
            }
            set { }
        }

        static private void ResetTestStudentsData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>(1);
                _testStudents.Add(new Student());
                _testStudents[0].name = "Ivan";
                _testStudents[0].middleName = "Nikolaev";
                _testStudents[0].familyName = "Fimov";
                _testStudents[0].faculty = "FKST";
                _testStudents[0].specialty = "ITI";
                _testStudents[0].educationalDegree = "Bachelor";
                _testStudents[0].status = "Unknown";
                _testStudents[0].facultyNumber = "501219051";
                _testStudents[0].course = 3;
                _testStudents[0].stream = 9;
                _testStudents[0].group = 36;
            }
        }
    }
}
