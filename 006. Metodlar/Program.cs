using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 006. Metodlar
•   C/C++ dillerinde fonksiyon olarak kullandığımız ismi C# üzerinde method/metod olarak kullanılıyor.
•   Emin olmamakla birlikte, Main scopeunun altına tanımlandığında Main'den çağırıldığında çalışıyor.
    Prototip gerektirmiyor ancak başındaki anahtar kelimeyle ilgisi olduğunu da düşünüyorum. Daha doğru
    bir yazım tekniği öğrendiğimde güncelleyeceğim.
•   Şimdilik static'in kullanım amacından da emin olmadığı için bu satır da güncellenecek
•   hw() geri dönüş türü olmayan void metod, Hello, world! yazdıracak.
•   usAl() ise int döndüren, gönderilen sayının üssünü alan metod, ikisini sırasıyla kullandık.
•   Eski pow(x,y) şeklindeki sayının kuvvetini bulan metod, Math.Pow(x,y) olmuş ve double değer döndürdüğü
    için Convert.ToInt32 içerisinde alıp metodun dönüş değerine uyarladık.
 */

namespace _006.Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hw();   // Hello, World! yazdıracak olan metod (Orijinal yazımıdır)

            // Burada da kullanıcıdan değer isteyip sonra altındaki cw satırında kullanıyoruz.
            Console.Write("Lütfen üssünü almak istediğiniz sayıyı girin: ");
            int a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(a+ " sayısının üssünü alan metodun döndürdüğü değer: "+usAl(a));

            Console.ReadKey();
        }

        static void hw()
        {
            Console.WriteLine("Hello, World!");
        }

        static int usAl(int i)
        {
            // pow C# dilinde Math.Pow olmuş ve geriye double döndürüyor, int'e convert edip döndürdük
            return Convert.ToInt32(Math.Pow(i, 2));
        }

    }
}
