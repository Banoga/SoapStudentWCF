using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapStudentWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static List<Student> students = new List<Student>();


        public Student AddStudent(string name, int id, int age)
        {
            Student st = new Student() { Age = age, Id = id, Name = name };
            students.Add(st);
            return st;
        }

        public Student FindStudent(int id)
        {
            return students.Find(student => student.Id == id);

        }

        public int RemoveStudent(int id)
        {
            throw new NotImplementedException();
        }

        public int EditStudent(string name, int id, int age)
        {
            throw new NotImplementedException();
        }

        public List<Student> FindAllStudent()
        {
            throw new NotImplementedException();
        }
    }
}
