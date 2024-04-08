using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016.Console_Settings_Coding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(55, 30);                  // Konsol x,y karakter uzunluğu belirleme
            Console.Title = "Console Settings";             // Pencere başlığı
            Console.BackgroundColor = ConsoleColor.White;   // Arka plan rengi
            Console.ForegroundColor = ConsoleColor.Blue;    // Yazı rengi
            Console.CursorLeft = 20;                        // Soldan 20
            Console.CursorTop = 10;                         // Üstten 10 karakter boşluk verdik


            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
