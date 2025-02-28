using pd01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_04_Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int option1;
            List<Ship> ships = new List<Ship>();
            do
            {
                Console.Clear();
                option1 = Shipmenu();
                if (option1 == 1)
                {
                    Ship s = Input1();
                    Storeinlist(ships, s);
                    Console.ReadKey();
                }
                else if (option1 == 2)
                {
                    Console.WriteLine("Enter Ship Number: ");
                    string shipnumber = Console.ReadLine();
                    Findlocation1(ships, shipnumber);
                    Console.ReadKey();
                }
                else if (option1 == 3)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's Degree: ");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude: ");
                    Console.WriteLine("Enter Longitude's Degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Ship s1 = new Ship(degree, minutes, direction, degree1, minutes1, direction1);
                    Findlocation2(ships, s1);
                    Console.ReadKey();
                }
                else if (option1 == 4)
                {
                    Console.WriteLine("Enter Ship Number: ");
                    string shipnumber = Console.ReadLine();
                    Findindex(ships, shipnumber);
                    Console.ReadKey();
                }
            }
            while (option1 != 5);
        }



        static void Findlocation1(List<Ship> ships, string shipnumber)
        {
            foreach (Ship ship in ships)
            {
                if (ship.shipnumber == shipnumber)
                {
                    Console.WriteLine("Ship is at " + ship.shiplocation1.degrees + "\u00b0" + ship.shiplocation1.minutes + "\'" + ship.shiplocation1.direction + " and " + ship.shiplocation2.degrees + "\u00b0" + ship.shiplocation2.minutes + "\'" + ship.shiplocation2.direction);
                }

            }
        }

        static void Findindex(List<Ship> ships, string shipnumber)
        {
            foreach (Ship ship in ships)
            {
                if (ship.shipnumber == shipnumber)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's Degree: ");
                    int degree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minutes: ");
                    float minutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction: ");
                    char direction = char.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Ship Longitude: ");
                    Console.WriteLine("Enter Longitude's Degree: ");
                    int degree1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minutes: ");
                    float minutes1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction: ");
                    char direction1 = char.Parse(Console.ReadLine());
                    Angle shipl1 = new Angle(degree, minutes, direction);
                    Angle shipl2 = new Angle(degree1, minutes1, direction1);
                    ship.shiplocation1 = shipl1;
                    ship.shiplocation2 = shipl2;
                }

            }
        }

        static void Findlocation2(List<Ship> ships, Ship s1)
        {
            foreach (Ship ship in ships)
            {
                if (ship.shiplocation1.degrees == s1.shiplocation1.degrees && ship.shiplocation1.minutes == s1.shiplocation1.minutes && ship.shiplocation1.direction == s1.shiplocation1.direction && ship.shiplocation2.degrees == s1.shiplocation2.degrees && ship.shiplocation2.minutes == s1.shiplocation2.minutes && ship.shiplocation2.direction == s1.shiplocation2.direction)
                {
                    Console.WriteLine("Ship's Serial Number is: " + ship.shipnumber);
                }

            }

        }

        static void Storeinlist(List<Ship> ships, Ship s)
        {
            ships.Add(s);
        }

        static int Shipmenu()
        {
            int option;
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter Your Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static Ship Input1()
        {
            Console.WriteLine("Enter Ship Number: ");
            string shipnumber = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude's Degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minutes: ");
            float minutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction: ");
            char direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude's Degree: ");
            int degree1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minutes: ");
            float minutes1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction: ");
            char direction1 = char.Parse(Console.ReadLine());
            Ship s = new Ship(shipnumber, degree, minutes, direction, degree1, minutes1, direction1);
            return s;
        }


    }
}
