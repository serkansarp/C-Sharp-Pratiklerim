using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
 013. Params
•   Metodları oluştururken alacakları değişken tip, sayı ve/veya direkt değerin kendisini giriyoruz
    bildiğimiz üzere. Bu değerleri sınırsız yapmak için params kullanıyoruz.
•   Biz static int topla(params int[] sayilar) şeklinde metodu başlattık, birden çok sayı gelebileceği
    için dizi gösterdik ve adını sayilar koyduk.
•   Fonksiyon içerisine de gelen bütün değerleri toplayan bir foreach döngüsü yazıp toplamı geri döndürdük.
•   Birden fazla params aynı metoda eklenemez, çok boyutlu diziler de kullanamayız.
•   params haricinde değerler de girmemiz gerekiyorsa metodda başta belirtmeliyiz. Yani
    static int topla(int a, params... şeklinde yazılmalı, zira params'ı en sona eklemeliyiz.
 */

namespace _013.Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fonksiyonun döndürdüğü değeri burada yazdırıyoruz
            Console.WriteLine(Topla(5, 8, 14, 21)); 

            

        }
        
        // Fonksiyon int döndürüyor, toplam=0 ile yeni değişken yaratıp sonuçta onu döndürüyoruz
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }



    }

    

}
