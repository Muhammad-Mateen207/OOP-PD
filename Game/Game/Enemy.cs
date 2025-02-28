using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
   
    internal class Enemy
    {
        private static Random random = new Random();
        public int EX;
        public int EY;
        public int EX2;
        public int EY2;
        public int EX3;
        public int EY3;
        public char[,] Maze;

        public Enemy(ref int eX, ref int eY, ref int eX2, ref int eY2, ref int eX3, ref int eY3, char[,] maze)
        {
            EX = eX;
            EY = eY;
            EX2 = eX2;
            EY2 = eY2;
            EX3 = eX3;
            EY3 = eY3;
            Maze = maze;

        }
        public void PrintEnemy()
        {
            Console.SetCursorPosition(EX, EY);
            Console.WriteLine("     ||======(********\\...  ");
            Console.SetCursorPosition(EX, EY + 1);
            Console.WriteLine("          /****************\\  ");
            Console.SetCursorPosition(EX, EY + 2);
            Console.WriteLine("         \\@@@@@@@@@@@@@@@@//  ");
        }

        public void EraseEnemy()
        {
            Console.SetCursorPosition(EX, EY);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX, EY + 1);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX, EY + 2);
            Console.WriteLine("                               ");
        }
        public void PrintEnemy2()
        {
            Console.SetCursorPosition(EX2, EY2);
            Console.WriteLine("     ||======(********\\...  ");
            Console.SetCursorPosition(EX2, EY2 + 1);
            Console.WriteLine("          /****************\\  ");
            Console.SetCursorPosition(EX2, EY2 + 2);
            Console.WriteLine("         \\@@@@@@@@@@@@@@@@//  ");
        }
        public void EraseEnemy2()
        {
            Console.SetCursorPosition(EX2, EY2);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX2, EY2 + 1);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX2, EY2 + 2);
            Console.WriteLine("                               ");
        }
        public void PrintEnemy3()
        {
            Console.SetCursorPosition(EX3, EY3);
            Console.WriteLine("     ||======(********\\...  ");
            Console.SetCursorPosition(EX3, EY3 + 1);
            Console.WriteLine("          /****************\\  ");
            Console.SetCursorPosition(EX3, EY3 + 2);
            Console.WriteLine("         \\@@@@@@@@@@@@@@@@//  ");
        }

        public void EraseEnemy3()
        {
            Console.SetCursorPosition(EX3, EY3);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX3, EY3 + 1);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(EX3, EY3 + 2);
            Console.WriteLine("                               ");
        }

        public void MoveEnemy()
        {
            //if (enemy1Defeated)
            //{
            //    return; // Exit if the enemy is defeated
            //}
            EraseEnemy();
            EY = EY + 1;
            if (EY == 30)
            {
                EY = 18;
            }
            PrintEnemy();
            Thread.Sleep(25);
        }
        public void MoveEnemy2()
        {
            EraseEnemy2();
            EX2 = EX2 - 1;
            if (EX2 == 5)
            {
                EY2 = random.Next(25, 45); // Random value between 25 and 44
                EX2 = 110;
            }
            PrintEnemy2();
            Thread.Sleep(25);
        }

        public void MoveEnemy3()
        {
            EraseEnemy3();
            EY3 = EY3 - 1;
            if (EY3 == 32)
            {
                EY3 = 43;
            }
            PrintEnemy3();
            Thread.Sleep(25);
        }
    }
}
