using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class Login
    {
        public static void Loginn ()
        {
            bool isilogin = false;
            while (isilogin == false)
            {
                // membersihkan layar dll
                //Console.Clear();
                //Console.ResetColor();

                // field
                Media.Kotak(0, 6, 26, 25, ConsoleColor.Magenta);
                Media.Kotak(27, 6, 118, 25, ConsoleColor.Red);
                splashscreen.logo(118,10,ConsoleColor.Magenta);
                
                string jdl_login = "-=  Ώ  L O G I N  Ώ  =-";
                Media.tuliss(jdl_login,2, 9,ConsoleColor.Magenta);
                Console.ForegroundColor = ConsoleColor.Magenta;
 
                string jdl_1 = "USERNAME";
                string pw_2  = "Password";
                string textbox = "";
                    
                // label
                Media.tuliss(jdl_1, 2, 14,ConsoleColor.Magenta);
                Media.tuliss(pw_2, 2, 17, ConsoleColor.Magenta);

                // textboox
                Media.tuliss(textbox, (120 - textbox.Length)/2, 15, ConsoleColor.White, ConsoleColor.Black);
                Media.tuliss(textbox, (120 - textbox.Length)/4, 18, ConsoleColor.White, ConsoleColor.Black);

                // inputan login
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(2, 15);
                string username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                string password = Input_Password(2, 18);

                // cek login
                if (username == "admin" && password == "123")
                {
                    // benar
                    isilogin = true;
                }
                else
                {
                    string error = "Maaf Username Dan Password Anda Salah !";
                    Media.tuliss(error, (120 - error.Length) / 2, 20,ConsoleColor.Red);

                    // lanjut login jika salah
                    string konfirm = " Press Any key to login again ";
                    Media.tuliss(konfirm, (120 - konfirm.Length) / 2, 22, ConsoleColor.Blue);
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
          public static string Input_Password (int col=0,int row=0)
        {
            var pass = string.Empty;

            ConsoleKey key;
            do
            {
                Console.SetCursorPosition(col, row);
                var keyinfo = Console.ReadKey(intercept: true);
                key = keyinfo.Key;
                if (key == ConsoleKey.Backspace && pass.Length >0)
                {
                    // hapus huruf
                    col--;
                    Console.SetCursorPosition(col +1, 15);
                    Console.Write("\b \b");
                    pass = pass.Substring(0, pass.Length - 1);
                }
                else if (!char.IsControl(keyinfo.KeyChar))
                {
                    // ketik karakter
                    col++;
                    Console.SetCursorPosition(col -1,row);
                    Console.Write("*");
                    pass += keyinfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return pass;
            
            
        }
        
    }
}
