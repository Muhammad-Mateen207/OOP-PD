using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManual_5_Task1_.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeduration;
        public int seats;
        public List<Subject> subjects;

        public DegreeProgram(string degreeName, float degreeduration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeduration = degreeduration;
            this.seats = seats;
            subjects = new List<Subject>();
        }   

        //public static bool isSubjectExists(string subjectCode, List<Subject> subjects)
        //{
        //    foreach (Subject subject in subjects)
        //    {
        //        if (subject.code == subjectCode)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public void AddSubject(Subject s)
        //{ 
        //    subjects = AddSubject(s);
        //}

        //public static void CalculateCreditHours(List<Subject> subjects)
        //{
        //    int totalCreditHours = 0;
        //    foreach (Subject subject in subjects)
        //    {
        //        totalCreditHours = totalCreditHours + subject.creditHours;
        //    }
        //    Console.WriteLine("Total Credit Hours: " + totalCreditHours);
        //}

        public int calculateCreditHours()
        {
            int count = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                count = count + subjects[i].creditHours;
            }
            return count;
        }

        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours <= 20)
            {
                subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isSubjectExists(Subject sub)
        {
            foreach (Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }
    }

}

