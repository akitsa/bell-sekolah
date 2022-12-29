using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class tampil
    {
        public static void Do()
        {
            // clear
            Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
            Media.tuliss(".:: Edit JADWAL ::.", 35, 7, ConsoleColor.Yellow, ConsoleColor.DarkBlue);

            //mengambil data dari tb_jadwal
            database db = new database();
            DataTable dtJadwal = db.GetData("SELECT * FROM tb_jadwal");

            //set judul tabel
            Media.Tulis(36, 9,  "╔════════════════════════════════════════════════════════╗", ConsoleColor.Blue);
            Media.Tulis(36, 10, "║  ID ║    HARI  ║    JAM     ║        KETERANGAN        ║", ConsoleColor.Blue);
            Media.Tulis(36, 11, "║════════════════════════════════════════════════════════║", ConsoleColor.Blue);


            //setting tampilan
            int jumlahdata = 10;//data perhalaman
            int hal = 1;//halaman aktif
            int pages = (dtJadwal.Rows.Count / jumlahdata) + (dtJadwal.Rows.Count % jumlahdata > 0 ? 1 : 0);//jumlah halaman

            //variable untuk mendeteksi tombol yang ditekan
            ConsoleKeyInfo k;

            do
            {
                //Media.bersihkan(29, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                // tampilan data
                int row = 0;

                for (int i = (hal - 1) * jumlahdata; i < (hal * jumlahdata); i++)
                {
                    if (i < dtJadwal.Rows.Count)
                    {
                        Media.tuliss(String.Format("        ║{0,5}║ {1,-8} ║ {2,8} ║ {3,-24} ║", dtJadwal.Rows[i]["id_jadwal"].ToString(), dtJadwal.Rows[i]["hari"].ToString(),
                        Convert.ToDateTime(dtJadwal.Rows[i]["jam"].ToString()).ToLongTimeString(), dtJadwal.Rows[i]["keterangan"].ToString()), 28, 12 + row, ConsoleColor.Blue);
                        row++;
                    }
                }
                // footer                   
                Media.Tulis(36, 15, "╚═════╙══════════╙════════════╙══════════════════════════╝", ConsoleColor.Blue);

                Media.Tulis(36, 23, string.Format("<< BACK (Press Left Arrow) | Halaman ke {0} dari {1} | (Press Right Arrow) NEXT >>", hal, pages), ConsoleColor.Yellow);

                k = Console.ReadKey(true);
                switch (k.Key)
                {
                    case ConsoleKey.RightArrow:
                        hal = hal == pages ? pages : hal + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        hal = hal == 1 ? 1 : hal - 1;
                        break;
                    case ConsoleKey.Escape:
                        //bersihkan area kontent
                        Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                        splashscreen.logowall(146,11,ConsoleColor.Magenta);
                        break;
                }

            } while (k.Key != ConsoleKey.Escape);

        }
}    }