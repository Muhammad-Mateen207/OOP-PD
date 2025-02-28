using LabManual_5_Task1_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.UI;

namespace LabManual_5_Task1_.DL
{
    class Subject_DL
    {
        public static List<Subject> SubjectList = new List<Subject>();
        public static void AddSubject(Subject sub)
        {
            SubjectList.Add(sub);
        }
        public static List<Subject> GetSubjectList()
        {
            return SubjectList;
        }
    }
}
