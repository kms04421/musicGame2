
using cshap;
using System;
using System.Text;
using System.Threading;

namespace practice0615
{
    public class Program
    {
        static void Main(string[] args)
        {


            Sartpage page = new Sartpage();
            musicMap musicMap = new musicMap(); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.OutputEncoding = Encoding.UTF8;
            page.startpage();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage1();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage2();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage3();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage4();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage5();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            page.startpage6();
            Thread.Sleep(200);
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
            musicMap.musicMaunu();
            musicMap.Djmax();

            Console.SetCursorPosition(30, 28);
            Console.WriteLine("아무키나 입력 시 시작!");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if(consoleKeyInfo != null)
            {
                MusicManu musicManu = new MusicManu();
                musicManu.Manu();

            }

          
        }


      
    }


}
