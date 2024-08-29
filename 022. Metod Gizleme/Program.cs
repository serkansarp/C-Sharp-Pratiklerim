using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022.Metod_Gizleme
{
    internal class Program
    {
        // Ana Sınıf
        class Ana
        {
            public void selamVer()
            {
                Console.WriteLine("Selam");
            }
        }

        // Türemiş Sınıf
        class Turemis : Ana
        {
            public new void selamVer()  // Metoda new eklediğimizde ana sınıftakini gizler
            {
                Console.WriteLine("Nasılsın?");
                base.selamVer();
            }
        }

        static void Main(string[] args)
        {
            Turemis turemis = new Turemis();
            // Ana sınıftakini görmezden gelerek kendi metodunu çalıştırdı.
            // Sonrasında ana sınıfa gidip onun metodunu çalıştırdı (base ile)
            turemis.selamVer();
            

            Console.ReadKey();
        }
    }
}
