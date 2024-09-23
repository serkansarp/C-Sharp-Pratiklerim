using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Checked ve Unchecked
- Tür dönüşümlerinde sınır aşılıp aşılmadığını kontrol eder.
- Örn. byte veri tipi 0-255 arası sayı taşır. Aşınca tekrar 0'a döner.
- C# default olarak unchecked olarak çalışır.
- İki türlü kullanımı vardır. Örnekte görebiliriz:


 */


namespace _037.Checked__Unchecked___Tür_Dönüşüm_Kontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Önce min-max değerlerini görelim
            Console.WriteLine("byte'ın min'i: " + byte.MinValue + " ve byte'ın max'ı: " + Byte.MaxValue);

            int a = 266;
            // byte b = a;          // Dönüşüm olmadığından çalışmaz
            byte b = (byte)a;       // Tür dönüşümü yaptık ama değeri değişti (default olarak unchecked olduğundan çalıştı)
            Console.WriteLine(b);   // 255, 0, 1, 2, 3, 4, 5 şeklinde çalıştığından %256 sonucunu döndürdü.
            
            // Checked
            checked
            {
                // byte c = (byte)a;    // Derleme hatası verecek olan satırdır, çünkü taşma (ve veri kaybı)
                // olduğunu bize belirtmesini istedik. checked bu işe yarar.

                a = 155;                // int a'yı byte sınırı içine çektik.
                byte c = (byte)a;
                Console.WriteLine(c);   // Hatasız yazdırırız, çünkü taşma yok

                a = 270;                // Yine sınırın dışına çıkardık
                // byte d = checked((byte)a);   // Hata verir, böyle de kullanabiliriz.
                byte d = unchecked((byte)a);    // unchecked olarak da kullanımı aynı. Taşma var ama kontrol etmiyor ve
                Console.WriteLine(d);           // veri kayıplı çıktımızı alıyoruz.
            }


            Console.ReadKey();

        }
    }
}
