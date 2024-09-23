using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ref Keyword
- ref ile referans, yani ramde gösterilen, değişkenin değerinin olduğu adres gösterilir.
- Pointer mantığıyla çalışır.
*/
namespace _035.Ref_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;             // Bir x değişkeni oluşturup 12 değerini verdik.
            ref int y = ref x;      // bir y değişkeni oluşturup referansını x'in referansına eşitledik.
            x = 95;                 // x'in değerini 95 yaptık
            Console.WriteLine(y);   // y de x'i gösterdiği için artık 95 çıktısı verecektir.

            Console.ReadKey();
        }
    }
}
