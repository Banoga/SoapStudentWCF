using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapStudentWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Student AddStudent(string name, int id, int age);

        [OperationContract]
        Student FindStudent(int id);

        [OperationContract]
        bool RemoveStudent(int id);

        [OperationContract]
        bool EditStudent(string name, int id, int age);

        [OperationContract]
        List<Student> FindAllStudent();

        [OperationContract]
        void Clear();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {


        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public int Id { get; set; }
    }


}

