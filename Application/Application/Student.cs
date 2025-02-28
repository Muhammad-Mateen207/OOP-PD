using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public float CGPA { get; set; }
        public Student(string regNo, string name, string department, string email, float cgpa)
        {
            RegNo = regNo;
            Name = name;
            Department = department;
            Email = email;
            CGPA = cgpa;
        }
    }
}
