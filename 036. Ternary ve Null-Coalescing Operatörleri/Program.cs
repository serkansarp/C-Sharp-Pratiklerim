using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ternary Operatör
- ? ve : karakterleri kullanılarak oluşturulur, if-else mantığıyla çalışır.
- Ternary (Üçlü) denilmesi, 'koşul ? doğru ise yapılacak : yanlış ise yapılacak' şeklinde yazılmasındandır.
- Microsoft Excel'deki IF/EĞER fonksiyonu gibi yazılır, örnekten kontrol edelim.
- Ek bilgi: null değer atanamayan int'i int? şeklinde yazarak nullable, null değer atanabilir hale getirdik.

Null-Coalescing (Null Birleşim) Operatörü ??
- Atama vb. kullanımlarda null değer geldiyse bir sonraki işleme atlar.
- Kullanımı: int x = a ?? b ?? 79 şeklinde olup a'ya bakar, null dönüyorsa b'ye bakar, sonra 79 atar.
- Daha fazla ?? ile de kullanılabilir.
  
 */
namespace _036.Ternary_ve_Null_Coalescing_Operatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary örnek
            int x = 50;
            string kucukBuyuk = (x < 100) ? "Küçük" : "Büyük";  // x, 100'den küçük olduğu için stringe Küçük atar.
            Console.WriteLine(kucukBuyuk);

            x = 110;    // Şimdi de büyüttük, aynı kodları kullanalım.
            kucukBuyuk = (x < 100) ? "Küçük" : "Büyük";  // x, 100'den küçük olduğu için stringe Küçük atar.
            Console.WriteLine(kucukBuyuk);

            Console.WriteLine();

            
            
            // Null-Coalescing Örnek
            int? a = null;  // Stringle gösterimi daha kolay olurdu, int null almaz ancak
            int? b = null;  // int? şeklinde yazarak null değer alabileceğini belirttik.
            
            int c = a ?? b ?? 45;   // Yeni int'imiz a nullsa b, o da nullsa c'yi atayacağız.
            Console.WriteLine(c);   // 45 çıktısını alacağız.

            Console.ReadKey();
        
        }
    }
}
