using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 002. DEĞİŞKENLER
•   Değişkenleri ve hangi aralıkta değer alabildiklerini göreceğim bir pratik.
•   Ayrıca Console.WriteLine ve değerlerin alt özelliklerini (örn. int.MaxValue)
    kullandım. "" içerisinde {0}{1} bana C'deki kullanımı hatırlattı ama karışık
    gelmişti. + ile de kullandım.
•   Tüm bunlarla birlikte alabildikleri sayı aralıklarını ve değişkenlerin
    kendilerini cw ile birlikte kullandım.

 */
namespace _002.Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  byte: 0-255 arası değerleri tutabilir, bellekte az yer tutar
            byte b = 1;

            //  short: -32768 +32767 arası sayıları tutabilir, byte'tan daha fazla
            //  byte gerekir (2x)
            short s = -31578;

            // int: -2147483648 ila 2147483647 arası sayıları tutar. shortx2 byte kaplar
            int i = 123456789;

            //  int'in 10 haneden fazla tutamaması, bize daha yüksek sayılarla
            //  (örn. TC Kimlik No) işlem yapacağımızda long'a geliriz.
            //  -1,79769313486232E+308 ila pozitifine kadar gider. 19 basamağa kadar
            //  yazılabilir.
            long l = 98765432123456789;

            //  float: Ondalık değerler (Sonuna f ya da F koymazsak double olarak algılar
            //  ki zaten hızlı yazarken direkt double kullanabiliriz, float biraz
            //  sıkıntılıdır. Ama gerekirse kullanabiliriz.
            float f = 9.85f;

            //  Double, float'tan daha uzun küsurat değer tutar, daha fazla byte ister.
            //  Double da bir tür floattır ama sonuna f ister.
            double d = 7.435432323;



            //  Bu arada değişkenlerin alt özelliklerini de (örn. int.MaxValue)
            //  görmüş oluyoruz ve cw ile değer almayı {0}{1}{2} ile nasıl
            //  yaptığımızı kontrol edelim. Satırı komple "" içerisinde yazılıp
            //  değişken gelecek yerleri sonrasında , ile sırasıyla ekliyoruz.
            //  Bu şekil yazımın kullanımı C++'tan biraz daha zor. Ama en altta
            //  değişkenlerimizi sırasıyla çağırdığımız kullanımı daha kolay ve C++'a
            //  yakın.
            Console.WriteLine("- DEĞİŞKENLER -");
            Console.WriteLine("- Tam Sayılar");
            Console.WriteLine("-- Byte: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim byte (b) değişkenimiz ise {2} değerini tutuyor.", byte.MinValue, byte.MaxValue, b);
            Console.WriteLine("-- Short: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim short (s) değişkenimiz ise {2} değerini tutuyor.", short.MinValue, short.MaxValue, s);
            Console.WriteLine("-- Int: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim int (i) değişkenimiz ise {2} değerini tutuyor.", int.MinValue, int.MaxValue, i);
            Console.WriteLine("-- Long: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim long (l) değişkenimiz ise {2} değerini tutuyor.", long.MinValue, long.MaxValue, l);
            Console.WriteLine("\n- Ondalıklı Sayılar:");
            Console.WriteLine("- Float: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim float (f) değişkenimiz ise {2} değerini tutuyor.", float.MinValue, float.MaxValue, f);
            Console.WriteLine("- Double: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim double (d) değişkenimiz ise {2} değerini tutuyor.", double.MinValue, double.MaxValue, d);

            //  Üstte bahsettiğim farklı bir output alma yöntemi de bu:
            Console.WriteLine("Değişkenlerimiz: " + b + " " + s + " " + i + " " + l + " " + f);





            Console.ReadLine();
        }
    }
}