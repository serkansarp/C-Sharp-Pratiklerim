using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 002. DEĞİŞKENLER
•   Değişkenleri ve hangi aralıkta değer alabildiklerini göreceğim bir pratik.
•   Float'ı double olarak gördüğü için sonuna f eklememiz gerektiğini unutmayalım.
•   Ayrıca Console.WriteLine ve değerlerin alt özelliklerini (örn. int.MaxValue) kullandım. "" içerisinde
    {0}{1} bana C'deki kullanımı hatırlattı ama karışık gelmişti. + ile de kullandım.
•   Tüm bunlarla birlikte alabildikleri, sayısal değerlerde sayı aralıklarını ve değişkenlerin kendilerini
    cw ile birlikte kullandım.
•   object'i ilk defa öğrendim ** . Tip dönüşümünde etkili bir değişkenmiş.
•   Konsolu bekletmek için Console.Readline()'dan Console.ReadKey()'e geçtim, artık enter
    yerine herhangi bir tuş, konsolu kapatabiliyor.
•   Mantıksal ve unary operatörler (=,==,!=,||,&&,!,<=,>=,<,>), işlem operatörleri (+,-,*,/,+=,-=,*=,/*
    hatta mod %), prefix/postfix işlemler (x++,--x) bilindiği için atlanılmıştır.
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

            //  Double, float'tan daha uzun küsurat değer tutar, floatx2 byte ister.
            //  Float: 7 ondalık basamak, Double: 15 ondalık
            double d = 7.435432323;

            //  Char: Tek karakter tutar, '' arasında atanır.
            char c1 = 'x';
            char c2 = '*';

            //  String: İçerisinde metin tutar ve "" arasında atanır. C ve C++'tan farklı olarak \n ve
            //  sonrasını da görür.
            string st = "En iyi kod çalışma zamanı gecenin körü ve çay olması da önemli.";

            //  Bool: 1/True veya 0/False değerini döndürür. Sadece 2 durumun olabileceği durumlarda kullanılır
            //  ve az yer kaplar. bool bo=true dışında, direkt değer atayarak değil de, daha  bir şekilde
            //  kullanacağım ve True döndürecek, çünkü işlem True olduğundan bo = True; yazmış olduk aslında,
            //  geniş kapsamlı kullanım alanı vardır ve bu daha işlevsel kullanımdır.
            bool bo = 3 > 2;

            //  * Object: (*: Pointer değil, önemli ve yeni gördüğümüz bir tip olduğunu belirtiyoruz): Her
            //  türlü değişkeni tutar. Değişkenlerin atasıdır ve tip dönüşümlerinde çok işe yarar.
            object o1 = 8;
            object o2 = 's';
            object o3 = "slm nbr";
            //  Yalnız bunun çıktısı virgül ile 3,14 şeklinde oluyor. Bilgisayarın dil ve bölge ayarlarına
            //  göre değişebilen bir durum bu. Tip dönüşümü ile yazılırken üstesinden gelinebiliyor.
            object o4 = 3.14;

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
            Console.WriteLine("-- Float: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim float (f) değişkenimiz ise {2} değerini tutuyor.", float.MinValue, float.MaxValue, f);
            Console.WriteLine("-- Double: {0} ila {1} arasındaki sayılarla işlem yaparken kullanılır. Bizim double (d) değişkenimiz ise {2} değerini tutuyor.", double.MinValue, double.MaxValue, d);
            
            Console.WriteLine("\n- Sözel Değerler:");
            Console.WriteLine("-- Char: Tek karakter tutar. Bizim iki char'ımız (c1, c2) sırasıyla {0} ve {1} değerlerini tutuyor.", c1,c2);
                //  Üstte bahsettiğim farklı bir output alma yöntemi de bu, bundan devam edeceğim sıkıntı çıkmazsa.
            Console.WriteLine("-- String: Metin tutar ve bizim metnimiz şöyle: " + st);

            Console.WriteLine("\n- Diğer Değişken Tipleri:");
            Console.WriteLine("-- Bool: Bool'umuz " + bo);
            Console.WriteLine("-- Object: Arka arkaya yazdığımız o1,o2,o3,o4 sırasıyla: "+o1+" "+o2+" "+o3+" "+o4);

            Console.WriteLine("\nDeğişkenlerimiz: " + b + " " + s + " " + i + " " + l + " " + f + " " + d + " "+c1+" "+c2+" "+st+" "+bo+" "+o1+" "+o2+" "+o3+" "+o4);

            // Console.ReadLine()'dan farklı olarak enter beklemiyor, Escape ile konsolu kapatabiliyor, 
            Console.ReadKey();
        }
    }
}