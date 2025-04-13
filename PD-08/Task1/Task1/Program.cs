using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.UI;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" -------------------------- ");
                Console.WriteLine("|  PERSON RECORD SYSTEM    |");
                Console.WriteLine(" -------------------------- ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Staff");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Search Staff");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");
                string option = Console.ReadLine();

                if (option == "1")
                    StudentUI.AddStudent();
                else if (option == "2")
                    StaffUI.AddStaff();
                else if (option == "3")
                    StudentUI.SearchStudent();
                else if (option == "4")
                    StaffUI.SearchStaff();
                else if (option == "5")
                    break;
                else
                    Console.WriteLine("Invalid option.");

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
