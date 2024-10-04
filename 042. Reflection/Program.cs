using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
- Reflection (a giriş)
•   Çok geniş bir konudur. Başka bir exe, dll dosyasından bilgi almaya, private özelliğini değiştirmeye,
    özellik, sınıf ve metotlarını kullanmaya kadar detaylı ve işlevselliği ile aynı oranda zor bir konudur.
•   Eklentiler için kullanılır. Bu pratikte bu detaylı kısmından çok, çalışan program içerisindeki türler
    hakkında bilgi vermesi, sorunların çözümünde kullanması kısmına eğildik, giriş yaptık yani.
•   YeniNamespace isimli en altta yeni bir namespace ve içerisine sınıf ve onun içerisine de class ekledik
    ve onları da görebiliyor hale geldik. Çünkü çalışan programı bir bütün olarak ele alır.
•   Attribute'ler ile kullanımı birçok kolaylık sağlayıp koda, hatta kodlayana yeni yetenekler ekler.
•   Type[] ise reflection ile kullanılan, program runtime'ında çalışan işlem ve metotlara dinamik olarak
    ulaşmayı sağlayan bir dizi türüdür.
•   Metotları invoke ile çağırabilir, Activator ile instance oluşturabilir, hatta private olsalar bile.
    Hatta derlenmiş dosyadan da bunları yapabiliyoruz. Ancak belirttiğim gibi pratik içerisinde yok.
*/

namespace _042.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assembly asm = Assembly.GetExecutingAssembly(); // Çalışan programı nesne olarak al
            Console.WriteLine(asm);                         // Bilgilerini yazdır
            Console.WriteLine();

            // Type[] ile çalışan türleri alıp foreach ile yazdırabiliriz. Type[] normal diziden farklıdır.
            // .Net içerisinde System.Type türünde farklı değişkenler (int, string, double vb.) alır. 
            Type[] types = asm.GetTypes();

            foreach (Type t in types)                   // Tipleri burada alıyoruz +
            {
                Console.WriteLine(t.FullName);          // ve yazdırıyoruz.

                foreach (var t2 in t.GetProperties())   // Döngü içerisinde tip içi propertyleri de burada alıp +
                {
                    Console.WriteLine(t2.PropertyType + " " + t2.Name);         // tip ve isimlerini yazdırıyoruz.
                }

                
            }


            Console.ReadKey();
        }
    }
    class Sinif1
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class Sinif2
    {
        public int Yas { get; set; }
        public int Boy { get; set; }
        public double Kilo { get; set; }
    }
}


// Kendi namespace'inin dışında olmasına rağmen reflection o anda çalışan programın içerisindeki
// bütün kısımları gösterir. Yani bu namespace içini de görebiliyoruz.
namespace YeniNamespace
{ 
    class Personel
    {
        public int Maas { get; set; }
        public string AdSoyad { get; set; }

        public void yazdir()
        {
            Console.WriteLine(AdSoyad);
            Console.WriteLine(Maas);
        }
    }
}
