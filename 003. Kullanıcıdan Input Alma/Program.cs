using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 003. KULLANICIDAN INPUT ALMA
•   Pratikte iki sayı inputu alarak ortalamasını buluyoruz. Anladığım kadarıyla C#, girilen değerleri
    önden string olarak kabul ettiği için sayı değerini de string olarak okuyacak. Bunu int'e dönüştüreceğiz.
•   Öncelikle değer istediğimiz satırdan sonra alt satıra düşmemesi için WriteLine yerine Write ile değerleri
    istedik.
•   Değeri okumak için ise Console.ReadLine kullanıyoruz. Okuyup input1'e atadık.
•   Sonra da sayi1 değişkeni oluşturup int.Parse ile sayıyı ayrıştırıp int olarak kabul ettik.
•   İkinci inputta ise int'i önden oluşturup if içerisinde int.TryParse kullandık. Bu içerisindeki
    sayıyı ayrıştırıp ayrıştıramayacağının kontrolü. int.TryParse(input, out sayi) ile ayrıştırma
    yapılıp yapılamadığına bakıyor, yapılıyorsa sayi2'ye atayacak. Sonrasında ortalamayı buluyor ancak
    sonuna f yazarak buçuklu çıkan sayıyı gösterebilmek için ekledik.
•   Eğer parse True dönmezse geçersiz olduğunu belirterek (sayi1+0)/2 yapmış oluyoruz, ilk sayının ortalaması.
•   Bu arada geçersiz olması, bize Beep'i de öğretmiş oldu, Do notasını (262) 500 ms çaldırdık.
 */

namespace _003.Kullanıcıdan_Input_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- ORTALAMA ALMA- ");

            Console.Write("Lütfen 1. sayıyı girin: ");
            string input1 = Console.ReadLine(); // Öncelikle string olarak input alıyoruz
            int sayi1 = int.Parse(input1);  // Sonrasında sayi1'e ayrıştırarak atıyoruz (parse ediyoruz)
            
            Console.Write("Lütfen 2. sayıyı girin: ");
            string input2 = Console.ReadLine(); 
            int sayi2;                              // Burada ise önden sayıyı oluşturduk
            if (int.TryParse(input2, out sayi2))    // TryParse'ın True dönüp dönmediğini kontrol ettik
            {
                sayi2 = int.Parse(input2);          // ve True olduğunda sayi2'ye atadık.
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");   // False durumunda ise hata yazdırıp ses çaldık.
                Console.Beep(262, 500);
            }
            Console.WriteLine("Girilen sayıların ortalaması: " + (sayi1 + sayi2) / 2f); // f: buçuklu değer
            Console.ReadKey();
        }
    }
}
