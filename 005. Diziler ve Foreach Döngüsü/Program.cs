using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 005. Diziler ve Foreach Döngüsü
•   C/C++ ile aynı kullanıldığı için önceki projede if-else if-else / switch-case /
    for-while-do-while-break-continue konularını atlayarak direkt geldiğimiz konu.
•   Dizi oluşturmayı önceden de biliyoruz. For ile yazdırırsak i<dizi.Length şeklinde koşul koyabiliyoruz,
    benim için yeni bir özellik. Daha önce sizeof() ile dizi size'ını 0. indisteki elemanın kapladığı değere
    böldürerek uzunluğunu hesaplıyor, ya değişkene atıyor ya da döngüde inline koşula yazıyordum.
•   Foreach döngüsü ise, örnekteki dizi için foreach(string a in calisanlar) şeklinde başlatılıyor ve her
    indisten sonra bir sonrakine geçerek yazıyor. Kullanımı basit, ayrıca kullanışlı bir araç, length
    gerektirmiyor.
 */

namespace _005.Diziler_ve_Foreach_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele isim ve soyisimlerden oluşturulmuş 5 elemanlı dizi
            string[] calisanlar = { "Mehmet Yılmaz", "Köksal Çelik", "Ekrem Çiçek", "Esra Doğan", "Elif Türkoğlu" };

            // Arada birer boşluk bırakarak çalışanların ismini (yani dizi elemanlarını) yazdıran for döngüsü
            for(int i = 0; i < calisanlar.Length; i++)
            {
                Console.Write(calisanlar[i]+" / ");
            }

            Console.WriteLine();



            // Bu da foreach döngüsü, foreach(diziTipi rastgeleDegisken in diziAdi) şeklinde kullanılarak
            // her bir indisi yazdırır. Length belirtmeye gerek duyulmaz, sonuna kadar yazar.
            foreach (string a in calisanlar)
            {
                Console.Write(a + " / ");
            }

            Console.ReadKey();
        }
    }
}
