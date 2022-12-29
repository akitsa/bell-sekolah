using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            splashscreen.logoo();
            Console.ResetColor();
            Console.Clear();
            splashscreen.run();
            Console.ResetColor();
            Console.Clear();
            Login.Loginn();

            Login.Input_Password();
            Console.Clear();
            splashscreen.logo(146, 11, ConsoleColor.DarkBlue);
            Console.ResetColor();
            Console.Clear();
            //dashboard
            //layout
            /**judul**/
            Media.Kotak(0, 0, 119, 4, ConsoleColor.Yellow);
            Media.bersihkan(1, 1, 118, 3, ConsoleColor.DarkYellow);
            /**Menu**/
            Media.Kotak(0, 5, 30, 25, ConsoleColor.Magenta);
            Media.bersihkan(1, 6, 29, 8, ConsoleColor.Red);
            /** konten**/
            Media.Kotak(31, 5, 119, 25, ConsoleColor.Red);
            
            /** footer**/
            Media.Kotak(0, 26, 119, 29, ConsoleColor.Yellow);

            // end layout

            // cetak judul 
            string namaApp = "BEL SEKOLAH - v1.0";
            string namaskl = "Program Ini Dibuat Dengan Sepenuh Hati";
            //string alamat = "";
            Media.Tulis((117 - namaApp.Length) / 2, 2, namaApp, ConsoleColor.Blue);
            Media.Tulis((117 - namaskl.Length) / 2, 3, namaskl, ConsoleColor.Blue);
            //Media.Tulis((117 - alamat.Length) / 2, 3, alamat, ConsoleColor.Blue);
            // footer
            Media.tuliss("created by : Bima",100,27,ConsoleColor.Magenta);
            Media.tuliss(" Tanggal   : " + DateTime.Today.Date.ToShortDateString(), 1, 27, ConsoleColor.Magenta);
            Media.tuliss(" Jam       : " + DateTime.Now.ToLongTimeString(), 1, 28, ConsoleColor.Magenta);

            // Menu Navigasi
            /* cetak menu*/
            int pos = 0;
            string[] menu = new string[6];
            menu[0] = "      Tambah       ";
            menu[1] = "      Edit         ";
            menu[2] = "      Hapus        ";
            menu[3] = "    Tampilkan      ";
            menu[4] = "    Jalankan       ";
            menu[5] = "    Keluar         ";

            Media.Tulis(2, 7, " -=      Menu      =-", ConsoleColor.Yellow);
            // cetak menu 
            for (int mn = 0; mn < 6; mn++)
            {
                Media.Tulis(3, 10 + mn, menu[mn], ConsoleColor.Yellow);
            }
            Media.tuliss("♥" + menu[pos].Substring(1, menu[pos].Length - 2) + "♥", 3, 10 + pos, ConsoleColor.Yellow, ConsoleColor.DarkMagenta);
            // set sorot

            bool jalan = true;
            
            while (jalan == true)
            {
                // sembunyi kursor
                Console.CursorVisible = false;

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyb = Console.ReadKey(true);
                    ;
                    
                    switch (keyb.Key)
                    {
                        case ConsoleKey.DownArrow:
                            Media.tuliss(menu[pos], 3, 10 + pos, ConsoleColor.Yellow);
                            pos++;
                            if (pos == 6) { pos = 5; }
                            Media.tuliss("♥" + menu[pos].Substring(1, menu[pos].Length - 2) + "♥", 3, 10 + pos, ConsoleColor.Yellow, ConsoleColor.DarkMagenta);
                            break;
                        case ConsoleKey.UpArrow:
                            Media.tuliss(menu[pos], 3, 10 + pos, ConsoleColor.Yellow);
                            pos--;
                            if (pos == -1) { pos = 1; }
                            Media.tuliss("♥" + menu[pos].Substring(1, menu[pos].Length - 2) + "♥", 3, 10 + pos, ConsoleColor.Red, ConsoleColor.DarkMagenta);
                            break;
                        // menekan tombol enter
                        case ConsoleKey.Enter:
                            switch(pos)
                            {
                                
                                case 0:
                                    Console.CursorVisible = true;
                                    tambah.Do();
                                    splashscreen.logowall(146, 11, ConsoleColor.Magenta);
                                    
                                    break;
                                    case 1:
                                    Console.CursorVisible = true;
                                    Edit.Do();
                                    
                                    splashscreen.logowall(146, 11, ConsoleColor.Magenta);
                                    break;
                                    case 2:
                                    Console.CursorVisible = true;
                                    Hapus.Do();
                                    
                                    break;
                                    case 3:
                                    Console.CursorVisible = true;
                                    tampil.Do();
                                    
                                    break;
                                    case 4:
                                    Console.CursorVisible = true;
                                    jalankan.Do();
                                    
                                    splashscreen.logowall(146, 11, ConsoleColor.Magenta);
                                    break;
                                    case 5:
                                    jalan = false;
                                    Console.ResetColor();
                                    Console.Clear();
                                    splashscreen.logoend();
                                    
                                    break;
                            }        
                            break;

                           
                       

                                 
                            





                    }




                }






            }
        }
    }
}
