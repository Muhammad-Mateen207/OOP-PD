using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;
using LabManual_5_Task1_.UI;

namespace LabManual_5_Task1_.DL
{
    class Student_DL
    {
        public static List<Student> studentList = new List<Student>();
        public static void AddStudent(Student s)
        {
            studentList.Add(s);
        }
        public static List<Student> getStudentList()
        {
            return studentList;
        }

        public static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.Merit = Student.CalculateMerit(s.FscMarks, s.EcatMarks);
            }
            sortedStudentList = studentList.OrderByDescending(o => o.Merit).ToList();
            return sortedStudentList;
        }

        public static void giveAdmission(List<Student> sortedList)
        {
            foreach (Student s in sortedList)
            {
                foreach (DegreeProgram d in s.preferences.OfType<DegreeProgram>())
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        d.seats--;
                        s.regDegree = d;
                        break;
                    }
                }
            }
        }
    }
}
