using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 007. OOP - Nesne Tabanlı Programlama
•   Öncelikle çok farklı değil, proje başlığına sağ tık ile (Visual Studio 2022) Add > Class ile
    ismini de girdikten sonra rahatlıkla kendi dosyasını oluşturuyor. Gördüğüm kadarıyla include
    yazmamız gerekmiyor.
•   public, private ve protected access modifiers kullanılıyor yine. Örnekte protected yok, inheritance
    konusunda girilmesi uygun.
•   Encapsulation ile verilere direkt erişimi engelliyor, getter ve setterlar aracılığıyla erişiyoruz.
•   Bu sırada karşımıza property isimli bir ekstra durum çıktı. Bir encapsulated değişkene farklı isimli
    public bir property ile (prop+tab*2) erişip get ve set edebiliyoruz. Property ismiyle set edilme
    işlemi varsa değeri value isimli keyword ile alıp private değişkene atıyor (yani atama olduğunu
    anlayıp set bloğunu çalıştırıyor; tersi durumda da get bloğunu çalıştırıp private değişkeni get ediyor.
•   Alttaki örnekte insan1 nesnesini constructor (ctor+tab*2) ile kurduktan sonra yazdırıyoruz, sonra
    değerleri değiştirdikten sonra tekrar yazıyoruz ama gözden kaçmaması gereken şey, maas setterı kullanmayıp
    property aracılığıyla değere atama yapmamız.
•   Program sonuna ise ana program kod bloğu dışında oluşturduğumuz (hemen altında) pause fonksiyonumuzu
    çağırıyoruz. Bir satır boşluk, sonra "Press any key to continue..." yazdırıp tuş bekliyor. Zira bazen
    öylece çıktıya bakakalıyorum, bu yıllardır alıştığım bir mesaj. Kullanmaya devam edeceğim sanırım.
 */
namespace _007.OOP___Nesne_Tabanlı_Programlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan1 = new Insan("Sinan",45,80,"Berber",5000);
            insan1.print();

            insan1.setIsim("Mahmut");
            insan1.setYas(58);
            insan1.setKilo(92);
            insan1.setMeslek("Ayakkabı Satıcısı");
            insan1._maas = 10000; // value özel keywordüyle alıp maas değişkenine atar

            Console.WriteLine();
            insan1.print();

            pause();    // Altta kendi pause fonksiyonumuzu yazdığımız görülebilir, onu çağırdık.
        }

        static void pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }
}
