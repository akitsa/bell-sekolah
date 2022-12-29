using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Bell_sekolah
{
    internal class splashscreen
    {
        public static void logoo()
        {
            string[] logo = new string[9];
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            logo[0] = "───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───";
            logo[1] = "───█▒▒░░░░░░░░░▒▒█───";
            logo[2] = "────█░░█░░░░░█░░█────";
            logo[3] = "─▄▄──█░░░▀█▀░░░█──▄▄─";
            logo[4] = "█░░█─▀▄░░░░░░░▄▀─█░░█";
            logo[5] = "█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█";
            logo[6] = "█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█";
            logo[7] = "█░░║║║╠─║─║─║║║║║╠─░░█";
            logo[8] = "█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█";
            int row = 10; // awal cetak
            foreach (string logooItem in logo)
            {
                Console.SetCursorPosition((120 - logooItem.Length) / 2, row);
                Console.WriteLine(logooItem);
                row++;
            }
            // cetak nama app 
            string appname = "Program Bell Sekolah v1.0";
            string developer = " Created by Bima Prihartanto";
            Console.SetCursorPosition((120 - appname.Length) / 2, 20);
            Console.WriteLine(appname);
            Console.SetCursorPosition((120 - developer.Length)/2, 21);
            Console.WriteLine(developer);
            // loading
            for (int i = 0; i < 9; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(i, 28);
                Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
                Thread.Sleep(25);
                
            }
                
        }
        public static void run ()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string[] run = new string[13];
            run[0] = "██████╗░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗  ██████╗░███████╗██╗░░░░░██╗░░░░░";
            run[1] = "██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║  ██╔══██╗██╔════╝██║░░░░░██║░░░░░";
            run[2] = "██████╔╝██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║  ██████╦╝█████╗░░██║░░░░░██║░░░░░";
            run[3] = "██╔═══╝░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║  ██╔══██╗██╔══╝░░██║░░░░░██║░░░░░";
            run[4] = "██║░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║  ██████╦╝███████╗███████╗███████╗";
            run[5] = "╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░╚══════╝╚══════╝╚══════╝";
            run[6] ="";
            run[7] ="░██████╗███████╗██╗░░██╗░█████╗░██╗░░░░░░█████╗░██╗░░██╗";
            run[8] ="██╔════╝██╔════╝██║░██╔╝██╔══██╗██║░░░░░██╔══██╗██║░░██║";
            run[9] ="╚█████╗░█████╗░░█████═╝░██║░░██║██║░░░░░███████║███████║";
            run[10]="░╚═══██╗██╔══╝░░██╔═██╗░██║░░██║██║░░░░░██╔══██║██╔══██║";
            run[11]="██████╔╝███████╗██║░╚██╗╚█████╔╝███████╗██║░░██║██║░░██║";
            run[12]="╚═════╝░╚══════╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝";

            for(int i = 0; i < run.Length; i++)
            {
               // Console.SetCursorPosition((120 - run.le))   
                
                
                
            }
        }

       public static void logo (int col, int row, ConsoleColor warna = ConsoleColor.Magenta)
        {
            string[] logo = new string[12];

            logo[0] ="█░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀   █▀▀ █▄░█ ░░█ █▀█ █▄█";
            logo[1] ="▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄   ██▄ █░▀█ █▄█ █▄█ ░█░";
            logo[2] ="";     
            logo[3] ="▀█▀ █▀█   █▀▄▀█ █▄█   █▀█ █▀█ █▀█ █▀▀ █▀█ ▄▀█ █▀▄▀█";  
            logo[4] ="░█░ █▄█   █░▀░█ ░█░   █▀▀ █▀▄ █▄█ █▄█ █▀▄ █▀█ █░▀░█";
            logo[5] = "♫‌                                                          ♫‌";
            logo[6] = "█▄▄ █▄█    ░▄▄▄▄░";
            logo[7] = "█▄█ ░█░     ▀▀▄██►";
            logo[8] ="              ▀▀███►";
            logo[9] = "█▄▄ █ █▀▄▀█    ░▀███►░█►";
            logo[10]= "█▄█ █ █░▀░█    ░▀███►░█►";
            logo[11]= "                ▒▄████▀▀ ";
            //logo[9] =""

            // menammpilkan
            for (int i = 0; i < logo.Length; i++)
            {
                Media.tuliss(logo[i], (col - logo[i].Length) / 2, row + i,warna);
            }
            
        }
        public static  void logoend()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string[] logo1 = new string[13];

            logo1[0] = "████████╗██╗░░██╗░█████╗░███╗░░██╗██╗░░██╗░██████╗  ███████╗░█████╗░██████╗░";
            logo1[1] = "╚══██╔══╝██║░░██║██╔══██╗████╗░██║██║░██╔╝██╔════╝  ██╔════╝██╔══██╗██╔══██╗";
            logo1[2] = "░░░██║░░░███████║███████║██╔██╗██║█████═╝░╚█████╗░  █████╗░░██║░░██║██████╔╝";
            logo1[3] = "░░░██║░░░██╔══██║██╔══██║██║╚████║██╔═██╗░░╚═══██╗  ██╔══╝░░██║░░██║██╔══██╗";
            logo1[4] = "░░░██║░░░██╔══██║██╔══██║██║╚████║██╔═██╗░░╚═══██╗  ██╔══╝░░██║░░██║██╔══██╗";
            logo1[5] = "░░░██║░░░██║░░██║██║░░██║██║░╚███║██║░╚██╗██████╔╝  ██║░░░░░╚█████╔╝██║░░██║";
            logo1[6] = "░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░  ╚═╝░░░░░░╚════╝░╚═╝░░╚═╝";
            logo1[7] = "░█████╗░░█████╗░███╗░░░███╗██╗███╗░░██╗░██████╗░";
            logo1[8] = "██╔══██╗██╔══██╗████╗░████║██║████╗░██║██╔════╝░";
            logo1[9] = "██║░░╚═╝██║░░██║██╔████╔██║██║██╔██╗██║██║░░██╗░";
            logo1[10] = "██║░░██╗██║░░██║██║╚██╔╝██║██║██║╚████║██║░░╚██╗";
            logo1[11] = "╚█████╔╝╚█████╔╝██║░╚═╝░██║██║██║░╚███║╚██████╔╝";
            logo1[12] = "░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░";

            //int row1 = 2;
            for (int ab = 0; ab < 13; ab++)
            {
                Console.SetCursorPosition((120 - logo1.Length) / 20, 4 + ab);
                Console.WriteLine(logo1[ab]);
                Thread.Sleep(150);

            }
        }
        public static void logowall (int col, int row, ConsoleColor warna = ConsoleColor.Magenta)
        {
            String[] logo2 = new string[5];

            logo2[0] ="─▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄";
            logo2[1] ="█░░░█░░░░░░░░░░▄▄░██░█";
            logo2[2] ="█░▀▀█▀▀░▄▀░▄▀░░▀▀░▄▄░█";
            logo2[3] ="█░░░▀░░░▄▄▄▄▄░░██░▀▀░█";
            logo2[4] ="─▀▄▄▄▄▄▀─────▀▄▄▄▄▄▄▀";
            
            for(int b = 0; b < logo2.Length; b++)
            {
                Media.tuliss(logo2[b], (col - logo2[b].Length) / 2, row + b, warna);
            }

        }
    }
}





 
   
//
//
//
//
//




