using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class load
    {
        public static void loading1()
        {
            for (int i = 40; i <= 80; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(i, 24);
                Console.WriteLine("█▒▒▒▒▒▒▒▒▒");
                Thread.Sleep(50);
            }
        }
    }
}
