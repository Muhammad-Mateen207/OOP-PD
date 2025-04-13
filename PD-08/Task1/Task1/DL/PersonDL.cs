using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;

namespace Task1.DL
{
    public static class PersonDL
    {
        public static List<StudentBL> students = new List<StudentBL>();
        public static List<StaffBL> staff = new List<StaffBL>();

        public static StudentBL FindStudentByName(string name)
        {
            foreach (StudentBL s in students)
            {
                if (s.GetName().ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }

        public static StaffBL FindStaffByName(string name)
        {
            foreach (StaffBL s in staff)
            {
                if (s.GetName().ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}
