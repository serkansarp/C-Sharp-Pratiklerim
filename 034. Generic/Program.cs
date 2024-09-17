using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Generic
- Farklı veri türleri için kullanılabilirler.
- Sınıflara, alanlara, özelliklere <T> veya herhangi başka birşey, örneğin <Sey> veya <Thing> eklenerek
  kullanılır ama <T> daha açık görülür, kodun okunabilirliğini artırır. 
*/
namespace _034.Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;              // int
            double b = 2.5;         // double
            string c = "Selam!";    // string

            // Şimdi hepsini 'goster' metoduna göndereceğiz.
            goster(a);              // 5
            goster(b);              // 2.5
            goster(c);              // Selam!
                                    // çıktılarını alacağız.

            // Şimdi de farklı değişken tipinde diziler oluşturalım (aynı metodun overload metodunu kullanacak).
            int[] asalSayilar = { 2, 3, 5, 7, 11 };
            double[] doublelar = { 1.2, 2.4, 3.6, 4.8, 6.0, 7.2, 8.4 };
            string[] isimler = { "Cansu", "Barış", "Safiye", "Semra", "Çiğdem", "Atılım", "Emrah", "Tolga", "Sabiha", "Burcu", "Betül" };

            Console.WriteLine();

            // Üstteki int[], double[] ve string[] dizilerini gönderdiğimizde dizi geldiğini anlayıp overload metoda gidiyor.
            goster(asalSayilar);
            goster(doublelar);
            goster(isimler);

            Console.ReadKey();

        }

        public static void goster<T>(T degisken)    // Tek değişken gösterimi
        {
            Console.WriteLine(degisken);
        }

        public static void goster<T>(T[] dizi)      // Dizi içindeki elemanların tamamının gösterimi
        {
            foreach (T item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}