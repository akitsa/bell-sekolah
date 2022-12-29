using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bell_sekolah
{
    internal class Hapus
    {
        public static void Do()
        {
            bool ulang = true;

            do
            {
                // clear
                Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                Media.tuliss(".:: Edit JADWAL ::.", 34, 7, ConsoleColor.Black, ConsoleColor.DarkBlue);
                
                // mengambil mencari data 
                Media.tuliss("masukan id jadwal : ", 34, 10, ConsoleColor.Cyan);
                Console.SetCursorPosition(54, 10);
                int id = int.Parse(Console.ReadLine());

                database db = new database();
                DataTable rsjadwal = db.GetData("SELECT *FROM tb_jadwal WHERE id_jadwal=" + id);

                if (rsjadwal.Rows.Count > 0)
                {
                    //clear judul
                    Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);

                    // jika ketemu tampilkan
                    Media.tuliss(" Hari                :" + rsjadwal.Rows[0]["hari"].ToString(), 32, 10);
                    Media.tuliss(" Jam                 :" + Convert.ToDateTime(rsjadwal.Rows[0]["jam"].ToString()).ToLongTimeString(), 32, 11);
                    Media.tuliss(" Keterangan          :" + rsjadwal.Rows[0]["keterangan"].ToString(), 32, 12);
                    Media.tuliss(" Sound               :" + rsjadwal.Rows[0]["sound"].ToString(), 32, 13);

                    // konfirmasi hapus 
                    Media.tuliss("Apakah data ingin dihapus ? (y/n) :", 35, 17, ConsoleColor.Magenta);
                    Console.SetCursorPosition(70, 17);
                    string jawab = Console.ReadLine();

                    if (jawab.ToUpper() == "y")
                    {
                        try
                        {
                            database dbhapus = new database();
                            dbhapus.Execute("DELETE FROM tb_jadwal WHERE id_jadwal =" + id);
                        }
                        catch (Exception err)
                        {
                            Media.tuliss("Data Gagal Di Hapus !!!", 35, 18, ConsoleColor.Red);  
                            Media.tuliss(err.Message.ToString(), 35, 18, ConsoleColor.White);

                        }
                    }

                }
                else
                {
                    // jika data tidak ditemukan
                    Media.tuliss("Maaf Data tidak ditemukan !", 35, 18, ConsoleColor.Red);
                }
            } while (ulang = false);
            load.loading1();
            Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
            splashscreen.logowall(146, 11, ConsoleColor.Magenta);
            ulang = false;
        }





    }
}   










