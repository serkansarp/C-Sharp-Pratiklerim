using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Output_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi = 1.2345;
            Console.WriteLine("Sayi: {0,10:F2}", sayi);      // Toplam 10 satır ve 2 ondalık yazmasını sağladık
            Console.WriteLine("Sayı: {0,-10:F1}", sayi);     // Sayı, sonrasında 10 karaktere tamamlayacak kadar boşluk
            Console.WriteLine("Para Birimi: {0:C}", sayi);   // Ülke para birimini ekler.
            Console.WriteLine("Haneli Sayı: {0:D9}", 19);   // Başına 9 haneye tamamlayacak kadar 0 ekledik
            Console.WriteLine("Binlik Ayraçlı Sayı: {0:N}", 2544541);   // Binlik ayracı ekledik
            Console.WriteLine("Yüzdelik gösterim: {0:P}", 0.58);        // Sayıyı yüzde olarak yazdırdık

            Console.WriteLine();

            // Tarih Gösterimleri
            DateTime zaman = DateTime.Now;                                      // Önce zaman nesnesini oluşturuyoruz.
            Console.WriteLine(zaman + " -Zamanın tümü");                        // Düz yazdırma
            Console.WriteLine("{0:dd}" + " -Gün", zaman);                       // Sadece gün
            Console.WriteLine("{0:ddd}" + " -Haftanın günü (Kısa)", zaman);     // Haftanın hangi günü (kısa)
            Console.WriteLine("{0:dddd}" + " -Haftanın günü (uzun)", zaman);    // Haftanın hangi günü (uzun)
            Console.WriteLine("{0:MMM}" + " -Ay (kısa)", zaman);                // Ay (kısa)
            Console.WriteLine("{0:MMMM}" + " -Ay (uzun)", zaman);               // Ay (uzun)
            Console.WriteLine("{0:yy}"+" -Yıl (2 hane)", zaman);                // Yıl (son 2 hane)
            Console.WriteLine("{0:yyyy}"+" -Yıl", zaman);                       // Yıl
            Console.WriteLine("{0:hh}"+" -12'lik düzende saat", zaman);         // Saat (12'lik dilime göre ve 2 hane)
            Console.WriteLine("{0:HH}"+" -24'lün düzende saat", zaman);         // Saat (24 saat esasına göre)
            Console.WriteLine("{0:tt}"+" -ÖÖ/ÖS veya AM/PM", zaman);            // Saat (ÖS/ÖÖ veya sistem diline göre AM/PM şeklinde öğle öncesi veya sonrası)
            Console.WriteLine("{0:mm}"+" -Dakika", zaman);                      // Dakika
            Console.WriteLine("{0:ss}"+" -Saniye", zaman);                      // Saniye


            Console.ReadKey();
        }
    }
}
