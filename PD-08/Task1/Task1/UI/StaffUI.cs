using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;
using Task1.DL;

namespace Task1.UI
{
    class StaffUI
    {
        public static void AddStaff()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter school: ");
            string school = Console.ReadLine();
            Console.Write("Enter pay: ");
            double pay = double.Parse(Console.ReadLine());

            StaffBL staff = new StaffBL(name, address, school, pay);
            PersonDL.staff.Add(staff);
            Console.WriteLine("Staff added successfully.");
        }

        public static void SearchStaff()
        {
            Console.Write("Enter staff name to search: ");
            string name = Console.ReadLine();
            var staff = PersonDL.FindStaffByName(name);

            if (staff != null)
                Console.WriteLine(staff.ToString());
            else
                Console.WriteLine("Staff not found.");
        }
    }
}
