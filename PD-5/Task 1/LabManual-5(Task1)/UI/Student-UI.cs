using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManual_5_Task1_.BL;

namespace LabManual_5_Task1_.UI
{
    class Student_UI
    {
        private static List<Student> studentList = new List<Student>();
        public static string Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students of a specific program");
            Console.WriteLine("6. Register subjects for a specific student");
            Console.WriteLine("7. Calculate Fees for all registered students.");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            return choice;
        }

        public static Student InputforStudent()
        {
            string name;
            float FscMarks;
            float EcatMarks;
            string degreeProgram;
            int age;
            Console.WriteLine("Enter Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks: ");
            FscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks: ");
            EcatMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Degree Program: ");
            degreeProgram = Console.ReadLine();
            Student s = new Student(name, age, FscMarks,EcatMarks, degreeProgram);
            return s;
        }

        public static void printStudent()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " has been admitted in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.Name + " has not been admitted in any degree program");
                }
            }
        }

        public static void ViewRegisteredStudents()
        {
            Console.WriteLine("Name \t FSC \t Ecat \t Age ");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " \t " + s.FscMarks + " \t " + s.EcatMarks + " \t " + s.Age);
                }
            }
        }

        public static void ViewStudentInDegree(string degName)
        {
            Console.WriteLine("Name \t FSC \t Ecat \t Age ");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.Name + " \t " + s.FscMarks + " \t " + s.EcatMarks + " \t " + s.Age);
                    }
                }
            }
        }

        public static void calculateFees()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.Name + " has " + s.calculateFee() + " fees.");
                }
            }
        }
    }
}
