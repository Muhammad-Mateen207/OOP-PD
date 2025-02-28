using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {



        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Roles> user_role = new List<Roles>();

            string path = "C:\\Users\\HP\\Desktop\\C#\\Busi_App\\Application\\users_data.txt";

            read_Data(path, user_role);
            header();
            int option = login();
            while (option != 3)
            {
                switch (option)
                {
                    case 1:
                        header();
                        SignUp(path, user_role);
                        option = login();
                        break;
                    case 2:
                        header();
                        SignIn(user_role, students);
                        option = login();
                        break;
                    case 3:
                        header();
                        Console.WriteLine();
                        Console.WriteLine("Exiting The Application... GoodBye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }

        }

        public static int login()
        {
            int choice;
            Console.WriteLine();
            Console.WriteLine("1) Sign-Up");
            Console.WriteLine("2) Sign-In: ");
            Console.WriteLine("3) Exit ");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static void Admin_Menu(List<Student> students)
        {
            int option;
            Console.WriteLine("1) Add Student: ");
            Console.WriteLine("2) Delete Student: ");
            Console.WriteLine("3) Update Student Info: ");
            Console.WriteLine("4) Search Student: ");
            Console.WriteLine("5) View All Students: ");
            Console.WriteLine("6) Exit: ");
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                string choice = "1";
                while (choice == "1")
                {
                    Console.Clear();
                    header();
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Registration Number: ");
                    string regNo = Console.ReadLine();
                    Console.Write("Enter Student Department: ");
                    string department = Console.ReadLine();
                    Console.Write("Enter Student Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter CGPA: ");
                    float cgpa = float.Parse(Console.ReadLine());
                    students.Add(new Student(regNo, name, department, email, cgpa));
                    Console.WriteLine("Student Added Successfully!");
                    Console.Write("Do you want to add another student? (1/0): ");
                    choice = Console.ReadLine();
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
            else if (option == 2)
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No Student Record Found!");
                }
                else
                {
                    Console.Write("Enter Registration Number of Student to be Deleted: ");
                    string regNo = Console.ReadLine();
                    Student student = students.FirstOrDefault(s => s.RegNo == regNo);
                    if (student != null)
                    {
                        students.Remove(student);
                        Console.WriteLine("Student Record Deleted Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student Record Not Found!");
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
            else if (option == 3)
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No Student Record Found!");
                }
                else
                {
                    Console.Write("Enter Registration Number of Student to be Updated: ");
                    string regNo = Console.ReadLine();
                    Student student = students.FirstOrDefault(s => s.RegNo == regNo);
                    if (student != null)
                    {
                        Console.Write("Enter Student Name: ");
                        student.Name = Console.ReadLine();
                        Console.Write("Enter Student Department: ");
                        student.Department = Console.ReadLine();
                        Console.Write("Enter Student Email: ");
                        student.Email = Console.ReadLine();
                        Console.Write("Enter CGPA: ");
                        student.CGPA = float.Parse(Console.ReadLine());
                        Console.WriteLine("Student Record Updated Successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student Record Not Found!");
                    }
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
            else if (option == 4)
            {
                Console.Write("Enter Registration Number of Student to be Searched: ");
                string regNo = Console.ReadLine();
                Student student = students.FirstOrDefault(s => s.RegNo == regNo);
                if (student != null)
                {
                    Console.WriteLine("Student Record Found!");
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Department: " + student.Department);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("CGPA: " + student.CGPA);
                }
                else
                {
                    Console.WriteLine("Student Record Not Found!");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
            else if (option == 5)
            {
                Console.WriteLine("All Students Record: ");
                foreach (Student student in students)
                {
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Registration Number: " + student.RegNo);
                    Console.WriteLine("Department: " + student.Department);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("CGPA: " + student.CGPA);
                    Console.WriteLine();
                }

                Console.WriteLine("Press Any Key to Continue ...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
            else if (option == 6)
            {
                Console.WriteLine("Exiting The Application... GoodBye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                Console.WriteLine("Press Any Key to Continue ...");
                Console.ReadKey();
                Console.Clear();
                header();
                Admin_Menu(students);
            }
        }
        static void Student_Menu(List<Student> students)
        {
            int option;
            Console.WriteLine("1) View Profile: ");
            Console.WriteLine("2) File Complaint: ");
            Console.WriteLine("3) Exit: ");
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter your Registration Number: ");
                string regNo = Console.ReadLine();
                Student student = students.FirstOrDefault(s => s.RegNo == regNo);
                if (student != null)
                {
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Department: " + student.Department);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("CGPA: " + student.CGPA);
                }
                else
                {
                    Console.WriteLine("Student Record Not Found!");
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter your Registration Number: ");
                string regNo = Console.ReadLine();
                Console.WriteLine("Enter your Complaint: ");
                string complaint = Console.ReadLine();
                Console.WriteLine("Complaint Filed Successfully!");
            }
            else if (option == 3)
            {
                Console.WriteLine("Exiting The Application... GoodBye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

        }
        static void admin_header()   // HEADER OF ADMIN MENU
        {
            Console.WriteLine(" -------------------");
            Console.WriteLine(" |                 |");
            Console.WriteLine(" |   ADMIN MENU    |");
            Console.WriteLine(" |                 |");
            Console.WriteLine(" -------------------");
        }
        static void student_header()   // HEADER OF STUDENT MENU
        {
            Console.WriteLine(" ---------------------");
            Console.WriteLine(" |                   |");
            Console.WriteLine(" |   STUDENT MENU    |");
            Console.WriteLine(" |                   |");
            Console.WriteLine(" ---------------------");
        }

        public static void header()   // HEADER OF THE BUSINESS APPLICATION:
        {
            Console.Clear();
            Console.WriteLine(" \t\t      -----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" \t\t      |     #####   ######  ##   ##   ####      ######  ###  ## ########     ##       ##    #####   ###  ##   #####    ######   ###### ##       ## ###### ###  ##  ######   |");
            Console.WriteLine(" \t\t      |    ##   ##    ##    ##   ##   ##  ##    ##      #### ##    ##        ## #   # ##   ##   ##  #### ##  ##   ##  ##    ##  ##     ## #   # ## ##     #### ##    ##     |");
            Console.WriteLine(" \t\t      |    ##         ##    ##   ##   ##   ##   ##      #######    ##        ##  # #  ##   ##   ##  #######  ##   ##  ##        ##     ##  # #  ## ##     #######    ##     |");
            Console.WriteLine(" \t\t      |     #####     ##    ##   ##   ##    ##  ######  ## ####    ##        ##   #   ##   #######  ## ####  #######  ##  ##### ###### ##   #   ## ###### ## ####    ##     |");
            Console.WriteLine(" \t\t      |         ##    ##    ##   ##   ##   ##   ##      ##  ###    ##        ##       ##   ##   ##  ##  ###  ##   ##  ##     ## ##     ##       ## ##     ##  ###    ##     |");
            Console.WriteLine(" \t\t      |    ##   ##    ##    ##   ##   ##  ##    ##      ##   ##    ##        ##       ##   ##   ##  ##   ##  ##   ##  ##     ## ##     ##       ## ##     ##   ##    ##     |");
            Console.WriteLine(" \t\t      |     #####     ##     #####    ####      ######  ##   ##    ##        ##       ##   ##   ##  ##   ##  ##   ##   ######   ###### ##       ## ###### ##   ##    ##     |");
            Console.WriteLine(" \t\t      |                                                                                                                                                                     |");
            Console.WriteLine(" \t\t      |                                                       ######    ##      ##   ######   ######## #######  ##       ##                                                 |");
            Console.WriteLine(" \t\t      |                                                      ##     ##   ##    ##   ##    ##    ##     ##       ## #   # ##                                                 |");
            Console.WriteLine(" \t\t      |                                                      ##           ##  ##    ##          ##     ##       ##  # #  ##                                                 |");
            Console.WriteLine(" \t\t      |                                                        ######       ##       ######     ##     #######  ##   #   ##                                                 |");
            Console.WriteLine(" \t\t      |                                                             ##      ##            ##    ##     ##       ##       ##                                                 |");
            Console.WriteLine(" \t\t      |                                                      ##     ##      ##      ##    ##    ##     ##       ##       ##                                                 |");
            Console.WriteLine(" \t\t      |                                                       ######        ##       ######     ##     #######  ##       ##                                                 |");
            Console.WriteLine(" \t\t      -----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

        }

        static void read_Data(string path, List<Roles> user_role)
        {
            user_role.Clear();

            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            user_role.Add(new Roles(parts[0], parts[1], parts[2]));
                        }
                    }
                }
            }
        }

        static void Write_Data(string path, List<Roles> user_role)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (Roles user in user_role)
                {
                    file.WriteLine(user.username + "," + user.password + "," + user.role);
                }
            }

        }

        static bool IsValidUsername(string username)
        {
            return username.All(char.IsLetter);
        }

        static bool IsValidPassword(string password)
        {
            return password.All(char.IsDigit);
        }

        static void SignUp(string path, List<Roles> user_role)
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role (Admin/Student): ");
            string role = Console.ReadLine();

            if (IsValidUsername(username) && IsValidPassword(password))
            {
                if (user_role.Any(u => u.username == username))
                {
                    Console.WriteLine("Username already exists.");
                }
                else
                {
                    Roles newUser = new Roles(username, password, role);
                    user_role.Add(newUser);
                    Write_Data(path, user_role);
                    Console.WriteLine("Signup successful!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Username or Password. Try Again!");
            }

            Console.ReadKey();
        }

        static void SignIn(List<Roles> user_role, List<Student> students)
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your role (Admin/Student): ");
            string role = Console.ReadLine();

            Roles foundUser = user_role.FirstOrDefault(u => u.username == username && u.password == password && u.role.Equals(role, StringComparison.OrdinalIgnoreCase));

            if (foundUser != null)
            {
                Console.WriteLine("Correct Details Entered");

                if (foundUser.isAdmin())
                {
                    admin_header();
                    Admin_Menu(students);
                }
                else if (foundUser.isStudent())
                {
                    student_header();
                    Student_Menu(students);
                }
            }
            else
            {
                Console.WriteLine("Incorrect Details Entered");
            }

            Console.ReadKey();
        }

        public void ClearScreen()
        {
            Console.Clear();
            header();

        }
    }
}



