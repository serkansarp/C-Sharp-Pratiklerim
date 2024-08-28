using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readkey_Function_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            Console.WriteLine("\n" + KeyInfo.Key.ToString() + " tuşuna bastınız!..");
            */

            Random rnd = new Random();
            int rastgele = rnd.Next(2,4);
            elNereyeKapParametreliFonksiyon(rnd.Next(1, 31));


            Console.ReadKey();
        }

        static void elNereyeKapParametreliFonksiyon(int kap)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 101);
            int x = 100 - kap;
            int kafaOmuzGoz = (100 - kap) / 3;

            if (sayi >= kap)
            {
                Console.WriteLine("KAP");
            }
            else if (sayi < kafaOmuzGoz)
            {
                Console.WriteLine("Eller kafaya");
            }
            else if (sayi < kafaOmuzGoz * 2)
            {
                Console.WriteLine("Eller omuza");
            }
            else if (sayi < kafaOmuzGoz * 3)
            {
                Console.WriteLine("Eller göze");
            }
            else
            {
                Console.WriteLine("Error!");
            }


        }


    }
}
