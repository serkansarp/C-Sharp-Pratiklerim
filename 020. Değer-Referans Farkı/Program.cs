using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020.Değer_Referans_Farkı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, double, struct, uint, float vb. değer tiplerdir, stackte tutulur, hızlı erişilir.
            int a = 5;
            Console.WriteLine(a);

            // string, array, object, class, delegate, interface referans tiplerdir, heapte tutulur.
            // Stackte referansı tutulur, değer istendiğinde önce referansa başvurulur, o da heape gider.
            // Yavaş çalışır.
            int[] b = { 8, 64 };
            Console.WriteLine(b[0]+" " + b[1]);

            
            // Değiştirme metodlarını çalıştırıyoruz
            intDegistir(a);
            arrayDegistir(b);

            // Tekrar yazdırdığımızda int'in değişmediğini ancak referans tipi olan arrayin değiştiğini göreceğiz.
            // Çünkü değer tipleri metodlara kopyalanarak gönderilir, orijini değişmez, kopyasının değeri değişir.
            // Array referans olduğu için direkt değişir.
            Console.WriteLine(a);
            Console.WriteLine(b[0] + " " + b[1]);

            // Değer tipi değişkenin değerini değiştirmek istersek ref/out keywordlerinden birini kullanmamız gerekir.
            // ref ilk değer ister, genellikle tek değer için kullanımı uygundur, out ise birden fazla değer için
            // uygundur.
            intDegistir2(ref a);    // Metodunda da, çağırırken de başına ref veya out yazarak kullanabiliriz.
            Console.WriteLine(a);   // Değerin değiştiğini görüyoruz.


            Console.ReadKey();
        }

        static void intDegistir(int x)
        {
            x = 12;
        }
        
        static void arrayDegistir(int[] x)
        {
            x[0] = 9;
            x[1] = 10;
        }

        static void intDegistir2(ref int x)
        {
            x = 70;
        }
    }
}
