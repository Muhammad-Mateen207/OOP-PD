using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;
using LabManual_5_Task1_.UI;

namespace LabManual_5_Task1_.DL
{
    class DegreeProgram_DL
    {
        public static List<DegreeProgram> degreeList = new List<DegreeProgram>();
        public static void AddDegreeProgram(DegreeProgram d)
        {
            degreeList.Add(d);
        }
        public static List<DegreeProgram> GetDegreeList()
        {
            return degreeList;
        }

    }
}
