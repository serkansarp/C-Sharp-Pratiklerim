using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

/*
- Nested (İç İçe Sınıflar)
• Kod okunabilirliğini artırmak + 
• Encapsulation gereği (Daha iyi kapsülleme sağlar) +
• İçteki (inner) sınıfı sadece dıştaki (outer) sınıfın kullandığı durumlar için çok kullanışlıdır.
• İç içe sınıfların birleşiminden outer sınıf oluşur, her biri outer sınıfın parçasıdır. has-a yaklaşımı, içsel ilişki
  vardır (containment, içerme). (Kalıtımda ise is-a, hiyerarşi yaklaşımı vardı.)
• Ek-1: Outer sınıf öğelerine inner sınıftan ulaşmak için nesne üretebilir ya da outer sınıfı static yapabiliriz. Ancak
  static sınıfların tüm öğelerinin de static olması gerekliliği, nested classlar için geçerli değil. Yani inner
  classlar non-static kalabilir.
• Ek-2: GetType().FullName kullanımı ile de hangi sınıfın altında, + ile hangi sınıf içinde çalıştığını,
  nested olduğunu öğrenmiş olduk. Gerektiği durumlarda "replace" ile + yerine . karakterini gösterebiliriz.
  Yazılımcıların daha alışkın olduğu ve okunabilir bir kod olur ancak gereksiz bellek harcar.
 */

namespace _038.Nested__İç_İçe__Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araba a1 = new Araba(); // Aracın ana özellikleri
            a1.Marka = "Renault";
            a1.Model = "Megane";
            a1.UretimYili = 2022;
            a1.Renk = "Sarı";
            // GetType() ile nesne türünü alıp Console.WriteLine ile yazdırdık.
            string a1NesneTuru = a1.GetType().FullName;         // string'e ata
            Console.WriteLine(a1NesneTuru);                     // Nesne türünü yazdır
            Console.WriteLine(a1.Marka + " " + a1.Model + " " + a1.UretimYili + ", " + a1.Renk);  // Özelliklerini yazdır

            Console.WriteLine();

            // Kapı özellikleri
            Araba.Kapi k1 = new Araba.Kapi();    // 5 kapı belirttik.
            k1.Sayi = 5;
            // string'e atamadan direkt cw içerisinde nesne türünü yazdırıyoruz.
            Console.WriteLine(k1.GetType().FullName);
            Console.WriteLine("Kapı Sayısı: " + k1.Sayi);

            Console.WriteLine();

            Araba.Motor m1 = new Araba.Motor(); // Motor sınıfı içinde ise motor gücü ve yakıtını atadık.
            m1.MotorGucu = 1.6;
            m1.Yakit = "Benzinli";
            Console.WriteLine(m1.GetType().FullName);
            Console.WriteLine(m1.MotorGucu + " motor gücünde, " + m1.Yakit);




            Console.ReadKey();
        }
    }

    class Araba // Bir araba sınıfı ve içinde (bazı) parçalarını nesne olarak alabileceğimiz sınıflarını yazıyoruz.
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }
        public string Renk { get; set; }

        public class Kapi   // Erişim belirleyicileri default olarak private'tır ama public yaptık.
        {
            public int Sayi { get; set; }
        }

        public class Motor
        {
            public double MotorGucu { get; set; }
            public string Yakit { get; set; }
        }


    }

}
