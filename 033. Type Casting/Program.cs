using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033.Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 33.24;       // Double'ımız 33.24
            // int b = a;           // Türü farklı olduğu için dönüştürmez, derleme hatası verir.
            int b = (int)a;         // Ancak casting yaparak 33 olarak int'e dönüştürürüz.
            Console.WriteLine(b);   // 33 çıktısını verir, explicit (açık) castingdir, veri kaybına neden olabilir.

            int c = 44;
            double d = c;           // Hata vermez, implicit (kapalı) castingdir, veri kaybına neden olmaz.
            Console.WriteLine(d);    // 44'ü double yaptığımız için 44.00 gösterecektir.

            // Şimdi sınıf içerisinden dönüşümler.

            Deneme dnm = new Deneme();
            dnm.sayi = 11;
            // int e = dnm;         // Implicit veya
            // int e = int(dnm);    // Explicit dönüşümü nesneden int'e yapamayız.

            // Implicit operatörünü overload edersek yapabiliriz.

            int f = dnm;            // Overloadlı implicit işlemini sınıfta tanımladığımız için int döndürüyor.
            Console.WriteLine(f);

            Console.ReadKey();

        }
                
    }

    class Deneme
    {
        public int sayi;

        
        public static implicit operator int(Deneme f)   // Implicit operatör overload
        {
            return f.sayi;
        }
        
        // Yalnız veri kaybı yaşanmaması için explicit operatör overload yazıp tür main kodda tür dönüşümüyle
        // geri istersek, daha verimli olur. Yani üstteki implicit yerine explicit, ayrıca main kodda isterken de
        // (int)nesne şeklinde almamız lazım. Biraz daha çok ama güvenli kod.

    }

}
