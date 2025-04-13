using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    class StudentUI
    {
        public static void AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter program: ");
            string program = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter fee: ");
            double fee = double.Parse(Console.ReadLine());

            StudentBL student = new StudentBL(name, address, program, year, fee);
            PersonDL.students.Add(student);
            Console.WriteLine("Student added successfully.");
        }
        public static void SearchStudent()
        {
            Console.Write("Enter student name to search: ");
            string name = Console.ReadLine();
            var student = PersonDL.FindStudentByName(name);

            if (student != null)
                Console.WriteLine(student.ToString());
            else
                Console.WriteLine("Student not found.");
        }
    }
}
