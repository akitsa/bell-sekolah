using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class jalankan
    {
        public static void Do()
        {
            string hari = "";
            //set hari
            do
            {
               // Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                Media.Tulis(35, 10, "Masukkan Hari :", ConsoleColor.Yellow);
                Console.SetCursorPosition(50, 10);
                hari = Console.ReadLine();
            }
            while (hari == "");

            //tampilkan kondisi sekarang
            Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black);
            Media.Tulis(35, 10, "Hari      : " + hari.ToUpper(), ConsoleColor.Yellow);
            Media.Tulis(35, 11, "Tanggal   : " + DateTime.Now.ToLongDateString(), ConsoleColor.Yellow);
            Media.Tulis(35, 12, "===============================================================", ConsoleColor.Yellow);

            //pengecekan
            database db = new database();
            bool berhenti = true;
            while (berhenti == true)
            {
                Console.CursorVisible = false;

                //cetak jam
                Media.Tulis(35, 14, "Jam      : " + DateTime.Now.ToLongDateString(), ConsoleColor.Yellow);

                //cek ke database
                string sql = String.Format("SELECT * FROM tb_jadwal WHERE hari = '{0}' AND jam = #{1}#", hari.ToUpper(), DateTime.Now.ToLongTimeString());
                DataTable dtJadwal = db.GetData(sql);

                if (dtJadwal.Rows.Count > 0)
                {
                    Media.Tulis(35, 14, "Jadwal   : " + dtJadwal.Rows[0]["keterangan"].ToString(), ConsoleColor.Yellow);

                    //play sound
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = dtJadwal.Rows[0]["file"].ToString();
                    player.Play();
                }

                //loading
               

                //keluar
                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo kb = Console.ReadKey(true);
                    if (kb.Key == ConsoleKey.Escape)
                    {
                        berhenti = false;
                        //bersihkan area konten
                        Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                    }


                }
            }
        }
    }
}