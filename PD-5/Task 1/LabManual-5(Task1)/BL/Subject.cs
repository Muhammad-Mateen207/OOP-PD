using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;

namespace LabManual_5_Task1_.BL
{
    class Subject
    {
        public string code;
        public int subjectFee;
        public int creditHours;
        public string subjectType;

        public Subject(string code, int subjectFee, int creditHours, string subjectType)
        {
            this.code = code;
            this.subjectFee = subjectFee;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
        }


    }
}
