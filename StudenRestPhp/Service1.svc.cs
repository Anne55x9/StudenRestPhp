using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudenRestPhp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentServicephp" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentServicephp.svc or StudentServicephp.svc.cs at the Solution Explorer and start debugging.
    public class StudentServicephp : IStudentServicephp
    {
        private static readonly IList<Student> studentList = new List<Student>();
        private static int _nextid = 4;

        static StudentServicephp()
        {
            Student firstStu = new Student()
            {
                Id = 1,
                Name = "Hans",
                Start = 2015,
                School = "EASJ"

            };

            studentList.Add(firstStu);

            Student secondStu = new Student()
            {
                Id = 2,
                Name = "Morten",
                Start = 2016,
                School = "Esbjerg"
            };

            studentList.Add(secondStu);

            Student thirdStu = new Student()
            {
                Id = 3,
                Name = "Andy",
                Start = 2016,
                School = "Esbejg"
            };

            studentList.Add(thirdStu);
        }


        public IList<Student> GetStudents()
        {
            return studentList;
        }

        public Student GetStudent(string id)
        {
            int idNumber = int.Parse(id);
            return studentList.FirstOrDefault(student => student.Id == idNumber);
        }

        public Student AddStudent(Student student)
        {
            student.Id = _nextid++;
            studentList.Add(student);
            return student;
        }


        public Student UpdateStudent(string id, Student student)
        {
            int idNumber = int.Parse(id);
            Student existingStu = studentList.FirstOrDefault(b => b.Id == idNumber);
            if (existingStu == null)
            {
                return null;
            }
            existingStu.Id = student.Id;
            existingStu.Name = student.Name;
            existingStu.Start = student.Start;
            existingStu.School = student.School;
            return existingStu;
        }

        public Student DeleteStudent(string id)
        {
            Student student = GetStudent(id);
            if (student == null)
            {
                return null;
            }
            bool removed = studentList.Remove(student);
            if (removed)
            {
                return student;
            }
            return null;
        }

/// <summary>
/// Koden nederfor bruges ikke.
/// </summary>
/// <param name="value"></param>
/// <returns></returns>

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

    }
}
