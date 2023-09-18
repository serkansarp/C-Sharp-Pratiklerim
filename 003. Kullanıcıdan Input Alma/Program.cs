using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Kullanıcıdan_Input_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- ORTALAMA ALMA- ");

            Console.Write("Lütfen 1. sayıyı girin: ");
            string input1 = Console.ReadLine();
            int sayi1 = int.Parse(input1);
            
            Console.Write("Lütfen 2. sayıyı girin: ");
            string input2 = Console.ReadLine();
            int sayi2;
            if (int.TryParse(input2, out sayi2))
            {
                sayi2 = int.Parse(input2);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
                Console.Beep(320, 500);
            }
            Console.WriteLine("Girilen iki sayının ortalaması: " + (sayi1 + sayi2) / 2f);
            Console.ReadKey();
        }
    }
}
