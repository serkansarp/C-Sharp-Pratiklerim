using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 010. List
•   List, C# 2.0'dan sonra ArrayList'in yerine, daha güvenli ve performanslı olduğu için kullanılmaktadır.
•   ArrayList, elemanları object olarak alırken kullanımda tür dönüşümüne gerek duyulabilir, ayrıca eklenen
    elemanların List'te tür güvenliği, başta tür de belirtilerek sağlanır.
•   Örnek olarak calisanlar List'imiz aşağıda oluşturulup helperlar yardımıyla daha profesyonel kullanımını
    gösterdim. List'i bir sınıf, calisanlar'ı nesne, calisanlar.Add gibi araçları da sınıf fonksiyonu olarak
    düşünebiliriz, ki zaten öyleler.
•   .Add, yeni bir eleman ekler, boş calisanlar List'imize 3 çalışan ekledik ve foreach ile sırasıyla yazdırdık.
•   .Remove ile elemanı list'ten çıkardık ve tekrar yazdırdık, artık o elemanı listede görmüyoruz.
•   .Count, eleman sayısını verir, kullandık.
•   .Contains ile yazılan elemanın listede olup olmadığını kontrol ettik, True döndüğünü gördük.
•   .IndexOf, dizideki indisini verir, saymanın 0'dan başladığını unutmayalım.
•   .Insert ile belirttiğimiz indise eleman ekler
•   .Reverse, sırayı tersine çevirir
•   .Sort sıralı olarak düzenler.
•   
•   
•   
 */

namespace _010.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> calisanlar = new List<string>();
            calisanlar.Add("Hakan Uyar");       // .Add aracıyla yeni eleman eklenebilir.
            calisanlar.Add("Metin Köksal");
            calisanlar.Add("Semra Balta");
            
            foreach (string item in calisanlar) // Sırasıyla yazdırdık
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();    // Boş satır

            calisanlar.Remove("Metin Köksal");  // .Remove ile elemanı çıkarıyoruz

            foreach (string item in calisanlar) // Tekrar sırasıyla yazdırdık
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(calisanlar.Count);    // Kaç eleman olduğunu gösteren .Count helper'ı

            // Semra Balta çalışanının listede olup olmadığını denetleyen.Contains aracı
            Console.WriteLine(calisanlar.Contains("Semra Balta"));

            // İndisini almak için .IndexOf
            Console.WriteLine(calisanlar.IndexOf("Semra Balta"));

            // 1. indis (2. sıraya) Meriç Altan ekledik ve yazdırdık (Add'den farkı, indis belirtebilmemiz)
            calisanlar.Insert(1,"Meriç Altan");

            foreach (string item in calisanlar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            
            // Sırayı tersine çevirmek için kullanılır.
            calisanlar.Reverse();
            foreach (string item in calisanlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            // Alfabetik ya da -sayı ise- küçükten büyüğe sıralar.
            calisanlar.Sort();  
            foreach (string item in calisanlar)
            {
                Console.WriteLine(item);
            }


            pause();
        }
        static void pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
