using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Admin
    {
        public String RegistrationNumber;
        public String Name;
        public String Department;
        public String Email;
        public Admin(string name, string email, string department, string RegNo)
        {
            RegistrationNumber = RegNo;
            Name = name;
            Email = email;
            Department = department;
        }

    }
}

