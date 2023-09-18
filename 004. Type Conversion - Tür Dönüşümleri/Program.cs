using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 004. Type Conversion - Tür Dönüşümleri
•   Önemli ve sık kullanacağımız bir işlem olduğunu, ancak zor da olduğunu ve iyi öğrenmemiz gerektiğini
    kabul edelim. string a = 5 yazdıramayız, çünkü derleyici int olduğunu fark edince hata fırlatacak. Bu
    arada değerlerin tiplerini degisken.GetType() şeklinde alabileceğimizi öğrendik.
•   int to byte dönüşümü kodun başlangıcında tanıtıldı. byte a2 = (byte)a1 şeklinde yapılıyor, biraz farklı
    ve aklımızın bir köşesinde kalması için, bu tip dönüşümlerde byte 0-255 arası sayı tutabildiği için,
    daha yüksek sayılardaki dönüşümlerde 255 veya katlarını çıkarıp <=255 değeri yazdırıyor tahmin ediyorum.
    Diğer benzer türler arasında da aynısını yapıyor.
•   string to int dönüşümünü önceki konudan int.Parse ile yapıldığını biliyoruz. Hatta oradan int.TryParse()'ı
    da biliyoruz. Onun haricinde bir de Convert.ToInt32() ile yapılmış örneğini de ekledim.
•   int ve double'ı string'e i.ToString() ile dönüştürdük.
•   double to int için ise yine Convert.ToInt32() kullandık ama int'e dönüşen double'ın küsuratlı kısmı
    biliyoruz ki göz ardı ediliyor, sadece tam sayı kısmı alınıyor.
•   -- Console.ReadLine() ile kullanıcıdan alınan veriler hep string tipinde olur ve dönüşüm gerekir --
•   Bu arada öğrendiğimiz bir bilgi, kodun yapısını düzenlemek için: Ctrl+k-d
•   Sırasıyla öğrendiklerimiz: .GetType() / byte()i / Parse / Convert.ToInt32() / CTRL+K-D
•   -- C/C++ ile aynı kullanıldığı için atlanan konular: if-else if-else / switch-case /
    for-while-do-while-break-continue.
 */

namespace _004.Type_Conversion___Tür_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // -- INT->BYTE DÖNÜŞÜMÜ
            int i1 = 121;
            byte b1 = (byte)i1;   // i'yi byte olarak j değişkenine atadık. 255 üstü için değer kaybı olur.

            Console.WriteLine(i1.GetType() + " " + i1 + " : i1'in tipi ve değeri");
            Console.WriteLine(b1.GetType() + " " + b1 + "  : b1'in tipi ve değeri");

            // -- STRING->INT DÖNÜŞÜMÜ
            string s1 = "3";    // Burada da 2 adet string yazdık ama içerilerine sayı yazdık.
            string s2 = "4";    // Console.WriteLine() ile toplamaya çalışsak yan yana yazacak.

            // 2 farklı şekilde dönüşüm mümkün
            int i3 = int.Parse(s1);          // Parse ile dönüştürebiliriz
            int i4 = Convert.ToInt32(s2);    // Bu da diğer dönüşüm şekli
            Console.WriteLine("i3 ile i4'ün toplamı: " + (i3 + i4));   // Toplam yaptığımız satır


            // -- INT/DOUBLE->STRING DÖNÜŞÜMÜ
            int i5 = 8;
            double d1 = 10.5;

            string s3 = i5.ToString();   // Her türlü sayısal değeri stringe dönüştüren ToString() ile yapıyoruz
            string s4 = d1.ToString();

            Console.WriteLine("String yaptığımız 2 sayının toplamı, yan yana yazılması şeklinde oluyor: " + (s3 + s4));


            // -- DOUBLE->INT DÖNÜŞÜMÜ
            double d2 = 3.445457;
            int i6 = Convert.ToInt32(d2);
            Console.WriteLine("Convert ile double->int dönüşümü tahmin ettiğimiz gibi: " + d2 + " -> " + i6);


            // -- Write/WriteLine'dan ÇİFT DEĞİŞKEN TUTMADAN İÇ İÇE DÖNÜŞÜM
            Console.Write("Lütfen yaşınızı girin: ");
            int i7 = Convert.ToInt32(Console.ReadLine());   // Convert.ToInt32() içinde readline kullanarak
            Console.WriteLine("Yaşınız: " + i7);            // direkt dönüştürüyoruz


            Console.ReadKey();
        }
    }
}
