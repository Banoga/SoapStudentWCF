using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapStudentWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapStudentWCF.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void AddStudentTest()
        {
            IService1 service = new Service1();
            Student st = service.AddStudent("Jens", 1, 27);
            Assert.AreEqual("Jens", st.Name);
        }

        [TestMethod()]
        public void FindStudentTest()
        {
            IService1 service1 = new Service1();
           Student st = service1.FindStudent(37);
            Assert.IsNull(st);
            Student st1 = service1.AddStudent("Jens", 1, 27);
            Student st2 = service1.FindStudent(1);
            Assert.AreEqual("Jens", st2.Name);
        }

        [TestMethod()]
        public void RemoveStudentTest()
        {

           IService1 service2 = new Service1();
            //Student st1 = service2.AddStudent("Jens", 2, 27);

            bool b = service2.RemoveStudent(2);
            
            //Assert.IsNull(b);
            Assert.IsFalse(b);
            
        }

        [TestMethod()]
        public void EditStudentTest()
        {
          IService1 service3 = new Service1();
            Student st1 = service3.AddStudent("Jens", 1, 27);
            bool b1 = service3.EditStudent("Jens", 1, 28);
            Assert.IsTrue(b1);
           Student st2 = service3.FindStudent(1);
            Assert.AreEqual(28, st2.Age);
        }

        [TestMethod()]
        public void FindAllStudentTest()
        {
            
        }
    }
}