using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- Anonymous Types - Anonim Tipler
• 'Sınıf obje = new Sınıf()' şeklinde sınıftan nesne oluştuluyor, biliyoruz, tip anonim olacağı için
  'var obje = new { isim = "ahmet", yas=15 } şeklinde oluşturabiliriz.
• Özellikleri yazdırabilir ama değiştiremeyiz. Get'leri vardır, set'leri yoktur yani.
• Nested mantığı da desteklerler. Örnekte anonim içindeki detaylar tipi ile gösterdim.
• En çok ihtiyaç duyuldukları alanlar LINQ sorguları (henüz işlemedik) ve geçici veri saklamak için kullanılır.
• Hızlıca geçici veri gruplamak ve LINQ sorguları için idealken, genel kullanım için veri kaybı yaratabilme
  ihtimaline karşı class ya da structlar kullanılması gerekir.
*/
namespace _039.Anonymous_Types___Anonim_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // anonim isimli bir tür oluşturup içine özelliklerini atadık.
            // Fark ettiyseniz özelliklerin de başında int, string vb. yok, derleyici kendi karar verecek.
            // detaylar adı altında yeni bir inner tip yaratıp iki özellik de oraya ekledik.
            var anonim = new { isim = "Selim", yas = 35, kilo = 76.5, detaylar = new { sacRengi = "Kumral", gozuMaviMi = false } };

            // Tip ve değerlerini yazdıralım
            Console.WriteLine(anonim.isim.GetType() + ":\t" + anonim.isim);  // String yaptı
            Console.WriteLine(anonim.yas.GetType() + ":\t" + anonim.yas);    // Int32 yaptı
            Console.WriteLine(anonim.kilo.GetType() + ":\t" + anonim.kilo);  // Double yaptı

            // Inner tipin iç tipleri ve değerleri ise:
            Console.WriteLine(anonim.detaylar.sacRengi.GetType() + ":\t" + anonim.detaylar.sacRengi);
            Console.WriteLine(anonim.detaylar.gozuMaviMi.GetType() + ":\t" + anonim.detaylar.gozuMaviMi);   // Bool yaptı


            Console.ReadKey();

        }
    }
}
