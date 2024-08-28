using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019.Const_Readonly_Farkı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Const değerleri sınıf içerisinden direkt çekerek yazdırabilirim.
            Console.WriteLine(Pi.piCo);

            // Readonly değerleri ise ancak nesne oluşturarak yazdırabilirim.
            Pi nesne = new Pi();
            Console.WriteLine(nesne.piRe);

            // Ayrıca readonly özelliklerin değeri constructorda da verilebilir, const hemen ister
            Pi nesne2 = new Pi(3.14);
            Console.WriteLine(nesne2.piConstructor);


            Console.ReadKey();

        }
    }


    // Const ve Readonly Pi'lerin tanımlı olduğu sınıf
    class Pi
    {
        public const double piCo = 3.14;
        public readonly double piRe = 3.14;

        public readonly double piConstructor;

        public Pi() { }     // Parametresiz constructor
        public Pi(double x) // Parametreli constructor
        {
            piConstructor = x;
        }
    }

}
