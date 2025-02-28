using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.DL;
using LabManual_5_Task1_.UI;
using LabManual_5_Task1_.BL;

namespace LabManual_5_Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = null;
            while (true)
            {
                string option = Student_UI.Menu();
                switch (option)
                {
                    case "1":
                        s = Student_UI.InputforStudent();
                        Student_DL.AddStudent(s);
                        break;
                    case "2":
                        DegreeProgram dp = DegreeProgram_UI.InputforDegreeProgram();
                        DegreeProgram_DL.AddDegreeProgram(dp);
                        break;
                    case "3":
                        List<Student> sortedList = new List<Student>();
                        sortedList = Student_DL.sortStudentsByMerit();
                        Student_DL.giveAdmission(sortedList);
                        Student_UI.printStudent();
                        break;
                    case "4":
                        Student_UI.printStudent();
                        break;
                    case "5":
                        Student_UI.ViewRegisteredStudents();
                        break;
                    case "6":
                        Subject_UI.registerSubjects(s);
                        break;
                    case "7":
                        Student_UI.calculateFees();
                        break;
                    case "8":
                        Console.WriteLine("Exiting the Application...");
                        return;
                    default:
                        Console.Write("Invalid Input...");
                        break;
                }
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}
