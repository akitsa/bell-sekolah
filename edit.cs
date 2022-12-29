using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bell_sekolah
{
    internal class Edit
    {
        public static void Do ()
        {
            bool ulang = true;

            do
            {
                // clear
                load.loading1();
                Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                Media.tuliss(".:: Edit JADWAL ::.", 33, 7, ConsoleColor.Black, ConsoleColor.DarkBlue);

                // mengambil mencari data 
                Media.tuliss("masukan id jadwal : ",33, 10, ConsoleColor.Cyan);
                Console.SetCursorPosition(53, 10);
                int id = int.Parse(Console.ReadLine());
                database db = new database();
                DataTable rsjadwal = db.GetData("SELECT *FROM tb_jadwal WHERE id_jadwal=" + id);

                if (rsjadwal.Rows.Count >0)
                {
                    //clear judul
                    //Media.bersihkan(29, 7, 118, 24);

                    // jika ketemu tampilkan
                    Media.tuliss(" Hari                :" + rsjadwal.Rows[0]["hari"].ToString(), 32, 10);
                    Media.tuliss(" Jam                 :" + Convert.ToDateTime(rsjadwal.Rows[0]["jam"].ToString()).ToLongTimeString(), 32, 11);
                    Media.tuliss(" Keterangan          :" + rsjadwal.Rows[0]["keterangan"].ToString(), 32, 12);
                    Media.tuliss(" Sound               :" + rsjadwal.Rows[0]["sound"].ToString(), 32, 13);

                    // label untuk data baru 
                    Media.tuliss(" .:: DATA BARU ::.",32,15,ConsoleColor.Cyan);
                    Media.tuliss(" Hari                : ",32,16,ConsoleColor.DarkCyan);
                    Media.tuliss(" Jam                 : ",32,17,ConsoleColor.DarkCyan);
                    Media.tuliss(" Keterangan          : ",32,18,ConsoleColor.DarkCyan);
                    Media.tuliss(" Sound               : ",32,19,ConsoleColor.DarkCyan);

                    //Media.bersihkan(27, 9, 118, 23);
                    // inputan data baru 
                    Console.SetCursorPosition(55, 16);
                    string Nhari = Console.ReadLine();
                    Console.SetCursorPosition(55, 17);
                    string Njam = Console.ReadLine();
                    Console.SetCursorPosition(55, 18);
                    string Nket = Console.ReadLine();
                    Console.SetCursorPosition(55, 19);
                    string Nsound = Console.ReadLine();

                    // konfirmasi hapus
                    Media.tuliss("Apakah data ingin disimpan ? (y/n) :",32,21,ConsoleColor.Magenta);
                    Console.SetCursorPosition(68, 21);
                    string jawab = Console.ReadLine();

                    if (jawab.ToUpper() == "y")
                    {
                        try
                        {
                            // menentukan data yang disimpan 
                            string hari = Nhari == "" ? rsjadwal.Rows[0]["hari"].ToString() : Nhari;
                            string jam = Njam == "" ? rsjadwal.Rows[0]["jam"].ToString() : Njam;
                            string ket = Nket == "" ? rsjadwal.Rows[0]["ket"].ToString() : Nket;
                            string sound = Nsound == "" ? rsjadwal.Rows[0]["sound"].ToString() : Nsound;

                            // proses simpan edit 
                            database dbedit = new database();
                            string sql = string.Format( "UPDATE tb_jadwal SET hari = '{0}',jam = '{1}',ket = '{2}', sound = '{3}', WHERE id_jadwal = {4}", hari.ToUpper(), jam, ket, sound.Replace("\"",""), id);
                            dbedit.Execute(sql);

                            Media.tuliss("Data Terupdate !!", 30, 22, ConsoleColor.Magenta);
                        }
                        catch(Exception err)
                        {
                            Media.tuliss(" Data Gagal Di Hapus !!, Error : " + err.Message.ToString(),32, 22, ConsoleColor.Red);    
                        }
                    }
                    else
                    {
                        Media.tuliss("Data Batal Dihapus !!",30,22, ConsoleColor.Red);
                    }
                }else
                {
                    // jika tidak ketemu
                    Media.tuliss(" Maaf data tidak ditemukan !", 32, 15, ConsoleColor.Red);
                }
                // ulang 
                Media.tuliss(" Apakah Ingin Menambah Data Kembali ? (y/n) : ", 32, 22, ConsoleColor.Cyan);
                Console.SetCursorPosition(77, 22);
                string njawab = Console.ReadLine();
                if (njawab.ToUpper() == "Y")
                {
                    ulang = true;
                }
                else
                    if (njawab.ToLower() == "N")
                {
                    
                    ulang = false;
                }


            } while (ulang = false);
            {
                load.loading1();
                Media.bersihkan(32, 7, 117, 24, ConsoleColor.Black, ConsoleColor.Black);
                //splashscreen.logowall(146, 11, ConsoleColor.Magenta);
                //Media.bersihkan(27, 6, 118, 23);
                ulang = false;
            }
            
        }
            

    }
}
