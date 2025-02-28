using LabManual_5_Task1_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.DL; 

namespace LabManual_5_Task1_.UI
{
    class DegreeProgram_UI
    {
        public static DegreeProgram InputforDegreeProgram()
        {
            string DegreeName;
            float DegreeDuration;
            int seats;
            Console.WriteLine("Enter Degree Name: ");
            DegreeName = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            DegreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Seats for Degree: ");
            seats = int.Parse(Console.ReadLine());

            DegreeProgram degProg = new DegreeProgram(DegreeName, DegreeDuration, seats);
            Console.WriteLine("Enter How Many Subjects You Want to Add: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Subject sub = Subject_UI.InputforSubject();
            }
            return degProg;
        }


    }
}
