using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capp
{
    class Interface
    {
        public static void Print(int x, int y, string s, ConsoleColor fg = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);   
            Console.ForegroundColor = fg;
            Console.WriteLine(s);
        }
        public static void MainWindow()
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 26;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Print(0, 0, "╔"); //201

            for (int i=1; i<79;i++) 
            {
                Print(i, 0, "═"); //201
                Print(i, 25, "═"); //201
            }
            Print(79, 0, "╗"); // 189
            Print(13, 0, "╤"); // 189
            Print(26, 0, "╤"); // 189
            Print(39, 0, "╗"); // 203
            Print(40, 0, "╔"); // 203
            Print(53, 0, "╤"); // 189
            Print(66, 0, "╤"); // 189

            Print(79, 25, "╝"); // 188
            Print(0, 25, "╚"); // 189
            for (int i = 1; i < 25; i++)
            {
                Print(0, i, "║"); //201
                Print(13, i, "│"); //179
                Print(26, i, "│"); //179
                Print(39, i, "║"); //179
                Print(40, i, "║"); //179
                Print(53, i, "│"); //179
                Print(66, i, "│"); //179
                Print(79,i, "║"); //201
            }
            Print(13, 25, "╧"); // 189
            Print(26, 25, "╧"); // 189
            Print(39, 25, "╝"); // 202
            Print(40, 25, "╚"); // 202
            Print(53, 25, "╧"); // 189
            Print(66, 25, "╧"); // 189

            Print(5, 1, "Name"); // 189
            Print(18, 1, "Name"); // 189
            Print(31, 1, "Name"); // 189
            Print(45, 1, "Name"); // 189
            Print(58, 1, "Name"); // 189
            Print(71, 1, "Name"); // 189




            Console.ReadKey();
        }

    }
}
