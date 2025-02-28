using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        public int PX;
        public int PY;
        public int BulletX;
        public int BulletY;
        public char[,] Maze;

        public Player(ref int pX, ref int pY, ref int bulletX, ref int bulletY, char[,] maze)
        {
            PX = pX;
            PY = pY;
            BulletX = bulletX;
            BulletY = bulletY;
            Maze = maze;
        }

        public void PrintPlayer()
        {
            Console.SetCursorPosition(PX, PY);
            Console.WriteLine("      ______                ");
            Console.SetCursorPosition(PX, PY + 1);
            Console.WriteLine("   -|||||||||| ==========  ");
            Console.SetCursorPosition(PX, PY + 2);
            Console.WriteLine("[|||||||||||||||||]        ");
            Console.SetCursorPosition(PX, PY + 3);
            Console.WriteLine(" \\OOOOOOOOOOOOOO/         ");
        }
        public void ErasePlayer()
        {
            Console.SetCursorPosition(PX, PY);
            Console.WriteLine("                           ");
            Console.SetCursorPosition(PX, PY + 1);
            Console.WriteLine("                           ");
            Console.SetCursorPosition(PX, PY + 2);
            Console.WriteLine("                           ");
            Console.SetCursorPosition(PX, PY + 3);
            Console.WriteLine("                           ");
        }
        public void MovePlayerRight()
        {
            if (Maze[PX + 32, PY] == ' ')
            {
                ErasePlayer();
                PX = PX + 1;
                PrintPlayer();
            }
        }
        public void MovePlayerLeft()
        {
            if (Maze[PX - 1, PY] == ' ')
            {
                ErasePlayer();
                PX = PX - 1;
                PrintPlayer();
            }
        }
        public void MovePlayerUp()
        {
            if (Maze[PX + 10, PY - 5] == ' ' && Maze[PX + 6, PY - 5] == ' ' && Maze[PX + 7, PY - 5] == ' ' && Maze[PX + 8, PY - 5] == ' ' && Maze[PX + 9, PY - 5] == ' ')
            {
                Console.SetCursorPosition(PY, PX);
                ErasePlayer();
                PY = PY - 1;
                Console.SetCursorPosition(PY, PX);
                PrintPlayer();
            }
        }
        public void MovePlayerDown()
        {
            if (Maze[PY, PX + 6] == ' ')
            {
                ErasePlayer();
                PY = PY + 1;
                PrintPlayer();
            }
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Game
//{
//    internal class Player
//    {
//        public int PX ;
//        public int PY ;
//        public int BulletX;
//        public int BulletY;
//        public char[,] Maze;

//        public Player(ref int pX, ref int pY, ref int bulletX, ref int bulletY, char[,] maze)
//        {
//            PX = pX;
//            PY = pY;
//            BulletX = bulletX;
//            BulletY = bulletY;
//            Maze = maze;
//        }

//        public void PrintPlayer()
//        {
//            Console.SetCursorPosition(PY, PX);
//            Console.WriteLine("      ______                ");
//            Console.SetCursorPosition(PY, PX + 1);
//            Console.WriteLine("   -|||||||||| ==========  ");
//            Console.SetCursorPosition(PY, PX + 2);
//            Console.WriteLine("[|||||||||||||||||]        ");
//            Console.SetCursorPosition(PY, PX + 3);
//            Console.WriteLine(" \\OOOOOOOOOOOOOO/         ");
//        }
//        public void ErasePlayer()
//        {
//            Console.SetCursorPosition(PY, PX);
//            Console.WriteLine("                           ");
//            Console.SetCursorPosition(PY, PX + 1);
//            Console.WriteLine("                           ");
//            Console.SetCursorPosition(PY, PX + 2);
//            Console.WriteLine("                           ");
//            Console.SetCursorPosition(PY, PX + 3);
//            Console.WriteLine("                           ");
//        }
//        public void MovePlayerRight()
//        {
//            if (Maze[PX + 2, PY] == ' ')
//            {
//                ErasePlayer();
//                PX = PX + 1;
//                PrintPlayer();
//            }
//        }
//        public void MovePlayerLeft()
//        {
//            if (Maze[PX - 1, PY] == ' ')
//            {
//                ErasePlayer();
//                PY = PY - 1;
//                PrintPlayer();
//            }
//        }
//        public void MovePlayerUp()
//        {
//            if (PY >= 4 && Maze[PY - 4, PX] == ' ')
//            {
//                Console.SetCursorPosition(PY, PX);
//                ErasePlayer();
//                PY = PY - 1;
//                Console.SetCursorPosition(PY, PX);
//                PrintPlayer();
//            }
//        }
//        public void MovePlayerDown()
//        {
//            if (PY<140 && Maze[ PY, PX + 6] == ' ')
//            {
//                ErasePlayer();
//                PX = PX + 1;
//                PrintPlayer();
//            }
//        }
//    }
//}
  