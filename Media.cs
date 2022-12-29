using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class Media
    {
        public static void Tulis(int col, int row, string text, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.WriteLine(text);
        }
        public static void Kotak(int col1, int row1, int col2, int row2, ConsoleColor warna = ConsoleColor.White)
        {
            // garis horisontal
            for (int col = col1; col <= col2; col++)
            {
                Tulis(col, row1, "─", warna);
                Tulis(col, row2, "─", warna);


            }
            // vertikal
            for (int row = row1; row <= row2; row++)
            {
                Tulis(col1, row, "│", warna);
                Tulis(col2, row, "│", warna);
            }
            Tulis(col1, row1, "┌", warna); // kiri atas
            Tulis(col1, row2, "└", warna); // kiri bawah
            Tulis(col2, row1, "┐", warna); // kanan atas
            Tulis(col2, row2, "┘", warna);

        }
        public static void tuliss(string text, int col, int row, ConsoleColor warna = ConsoleColor.White, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.ForegroundColor = warna;
            Console.BackgroundColor = bg;
            Console.SetCursorPosition(col, row);
            Console.WriteLine(text);
        }
        public static void bersihkan(int col1, int row1, int col2, int row2, ConsoleColor warna = ConsoleColor.Black, ConsoleColor bg = ConsoleColor.Black)
        {
            for (int c = col1; c <= col2; c++)
            {
                for (int r = row1; r <= row2; r++)
                {
                    Console.ForegroundColor = warna;
                    Console.BackgroundColor = bg;
                    Console.SetCursorPosition(c, r);
                    Console.WriteLine(" ");
                }
               
            }
        }



    }       
}
