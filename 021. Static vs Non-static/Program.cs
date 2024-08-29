using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021.Static_vs_Non_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static olan metodu direkt kullanabiliyoruz.
            yazdir("Selam");

            // Static olmayan kareAl metodunu kullanmak için nesne oluşturmamız gerekiyor
            Program nesne = new Program();
            nesne.kareAl(5);

            Console.ReadKey();
        }

        // Static keywordü metodu nesneden bağımsız hale getirir
        static void yazdir(string x)
        {
            Console.WriteLine(x);
        }

        public void kareAl(int i)
        {
            Console.WriteLine(i*i);
        }


    }
}
