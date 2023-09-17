using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
001. GİRİŞ
•   Öncelikle bu proje, C, C++ sonrası biraz Python syntaxini de öğrendikten
    sonra C# ile yaptığım pratiklerden ibarettir. Daha çok farklarını anlamaya
    yöneliktir. Direkt C# ile öğrenmeye başlayacaklara önerilmez, yoksa teorik,
    ön ezberli olması gereken basit bilgilerin gözden kaçmasına neden olur. Ayrıca
    kendi kodunuzu başından sonuna kadar kendiniz yazarak, yanlışlar yaparak
    düzelterek öğrenmenizi öneririm. Örnek kodlar üzerinde çalışmak -yaşa göre
    değişkenlik göstermekle birlikte- çabucak unutulur. Yine de önden bilgisi olan
    arkadaşlar için, kapsamlı C++ ile object-oriented programming bilenler için
    uygundur. Ancak onlar da bilirler ki, yorum satırsız kod yazdıktan bir süre
    sonra insan kendi yazdığı kodu hatırlayamıyor ve evet, yorum satırlarını da
    kendi yazması gerekiyor.
•   Görüldüğü üzere blok halinde yorum haline getirmek aynı, satır yorumu da altta
    görünüyor, aynı.
•   Kısayollar çok işe yarıyor, yani kod yazarken for yazıp n x tab yazınca kendisi
    bir for döngü kalıbı oluşturuyor. Console.WriteLine için de aynı şekilde.
    Yazıldığı yere göre tab veya taslakta farklılıklar olabiliyor. Bir
    Console.WriteLine()'ın altına c-w-tab yeterli oluyor örneğin.
•   Değişkene değer atama C++'tan çok farklı değil.
•   Console.WriteLine'ın satır sonuna endline yaptığını Write'ın yapmadığını görüyoruz.
•   Console.ReadLine() ise konsol hemen görünüp kapanmasın diye enter bekliyor.
•   Serkan SARP / Ankara @ 2023.9
  */

namespace _001.Giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Atama işlemleri aynı görünüyor (Yorum satırları da aynı)
            string h = "Hello, World!";

            // WriteLine, satır olarak yazıp sonunda endline yapar
            Console.WriteLine(h);
            Console.WriteLine("Selam");

            // Write, sadece yazar, endline yapmaz.
            Console.Write("Nasılsınız?");
            Console.Write("İyiyim, siz?");

            // Ekran hemen kapanmasın diye (C'deki conio gibi)
            Console.ReadLine();
        }
    }
}