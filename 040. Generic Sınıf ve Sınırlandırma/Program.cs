using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- Generic Sınıf ve Sınırlandırma
• Daha önce 2 kez farklı şekillerde işlediğimiz bu konuya bakışımız genel olarak her türlü değer içindi. Bu pratikte
  tip vererek başka tip almasının ve veri kaybının önüne geçiyoruz.
• Ek olarak sınırlandırmayı göreceğiz.
 */
namespace _040.Generic_Sınıf_ve_Sınırlandırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntSinifi<int> int1 = new IntSinifi<int>(); // <> içerisinde objenin tipini belirledik.
            int1.IntYazdir(2);

            StringSinifi<string> str1 = new StringSinifi<string>();
            Console.WriteLine(str1.StrYazdir("Çay içsek!"));    // Return ettiği için cw kullanıyoruz.

            Console.ReadKey();
        }
    }

    // T'nin tipi burada belli değil ancak Main'deki ilk satırda belirttik. Artık string almaz.
    class IntSinifi<T> where T : struct     // Sadece struct türü için kabul ediyoruz, int bir struct olduğu için
    {                                       // main'de altını kızartmıyor. class yazsak kızartacaktı (Compile error)
        public T x;

        public void IntYazdir(T a)
        {
            Console.WriteLine(a);
        }
    }

    // Yine main'de, bu sınıftan nesne oluştururken tip belirtiyoruz
    // ve içerisindeki bütün T'ler o tür oluyor.
    class StringSinifi<T> where T : class   // String de özünde class olduğu için hata vermeden sınırlandırabiliriz.
    {
        public T y;

        public T StrYazdir(T b) // Bu da değer döndürüyor
        {
            return b;
        }

    }

}
