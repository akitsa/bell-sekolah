using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Bell_sekolah
{
    internal class tambah
    {
        public static void Do()
        {

            bool ulangi = true;
            
            do
            {
                // judul
                Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                Media.tuliss(".:: TAMBAH JADWAL ::.", 32, 7, ConsoleColor.Yellow, ConsoleColor.Black);

                Media.tuliss(" Hari               :", 32, 10, ConsoleColor.Yellow);
                Media.tuliss(" Jam                :", 32, 12, ConsoleColor.Yellow);
                Media.tuliss(" Keterangan         :", 32, 14, ConsoleColor.Yellow);
                Media.tuliss(" Sound              :", 32, 16, ConsoleColor.Yellow);
                //Media.bersihkan(27, 6, 118, 23, ConsoleColor.Black, ConsoleColor.Black);
                // inputan
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(55, 10);
                string hari = Console.ReadLine();
                Console.SetCursorPosition(55, 12);
                string jam = Console.ReadLine();
                Console.SetCursorPosition(55, 14);
                string ket = Console.ReadLine();
                Console.SetCursorPosition(55, 16);
                string sound = Console.ReadLine();
                //Media.bersihkan(27, 6, 118, 23, ConsoleColor.Black, ConsoleColor.Black);
                // proses simpan
                Media.tuliss(" Apakah Data Ingin Disimpan ? (Y/N):", 32, 18, ConsoleColor.Magenta);
                Console.SetCursorPosition(69, 18);
                string jawab = Console.ReadLine();

                if (jawab.ToUpper() == "Y")
                {
                    try
                    {
                        database db = new database();
                           string sql = string.Format("Insert INTO tb_jadwal(hari,jam,keterangan,file) VALUES('{0}','{1}','{2}','{3}')",
                            hari.ToUpper(), jam, ket, sound.Replace("\"", ""));
                        db.Execute(sql);

                        Media.tuliss("Data Disimpan !!!", 32, 19, ConsoleColor.Green);
                    }
                    catch (Exception err)
                    {
                        Media.tuliss("Data Gagal Disimpan !!!", 32, 19, ConsoleColor.Red);
                        Media.tuliss(err.Message.ToString(), 32, 20, ConsoleColor.White);
                    }
                }
                else
                {
                    Media.tuliss(" Data Batal Disimpan", 32, 19, ConsoleColor.Red);
                }
                // ulangi
                Media.tuliss(" Apakah Ingin Menambah Data Kembali ? (y/n) : ", 32, 22, ConsoleColor.Cyan);
                Console.SetCursorPosition(77, 22);
                Console.ReadLine();
                //Media.bersihkan(27, 6, 118, 23, ConsoleColor.Black, ConsoleColor.Black);
                if (jawab.ToUpper() == "Y")
                {
                    ulangi = true;
                }
                //else if (jawab.ToLower() == "N")
                //{
                  //  ulangi = false;
                //}
                else
                    if (jawab.ToLower() == "N")
                {
                    
                    ulangi = false;
                }
                    
                








            } while (ulangi == false);
            {
                load.loading1();
                Media.bersihkan(32,7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                //splashscreen.logowall(146, 11, ConsoleColor.Magenta);
                ulangi = false;
            }
            







        }
    }
}
