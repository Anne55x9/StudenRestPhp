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


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public IList<Student> GetStudents()
        {
            return studentList;
        }
    }
}
