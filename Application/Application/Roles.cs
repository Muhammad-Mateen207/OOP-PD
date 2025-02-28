using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Roles
    {
        public string username;
        public string password;
        public string role;
        public Roles(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        //public bool isAdmin()
        //{
        //    if (role == "admin" || role == "Admin ")
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool isStudent()
        //{
        //    if (role == "student" || role == "Student")
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool isAdmin()
        {
            return role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        }

        public bool isStudent()
        {
            return role.Equals("Student", StringComparison.OrdinalIgnoreCase);
        }
    }
}
