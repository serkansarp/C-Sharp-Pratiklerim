using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
 009. Static Metod - Değişken - Constructor - Class
•   Metodların static özelliği, access modifierstan hemen sonra public static şeklinde belirlenir.
    - SinifAdi.Metod() şeklinde kullanılabiliyor ama nesne ürettikten sonra nesne ile kullanılamıyor.
    - Kedi sınıfındaki miyavla() örneğini Kedi.miyavla() şeklinde kullanarak gösterdik.
•   Static değişkenlere de değer atandıktan sonra direkt sinifAdi.degisken şeklinde ulaşabiliyoruz.
    - Nesne üzerinden ulaşamıyoruz.
•   Static consturtor 'static SinifAdi' şeklinde yazılıyor, 'public static SinifAdi' şeklinde değil.
    - Parametre almazlar ve ilk nesne oluştururken bir kere standart constuctordan önce çalıştırılır,
      sonraki nesnelerde atlanır.
    - Standart constructorlar yazılabilir, overload constructorlar yazılabilir. Sadece static constructorlı
      sınıf da olabilir.
    - Örneğimizi Ogrenci sınıfıyla oluşturup inceledik.
•   Static Sınıf: public static class SinifAdi{} şeklinde oluşturulur.
    - İçlerindeki her şey statik olmak zorundadır, statik olmayan herhangi bir şey tanımlanamaz.
    - Statik sınıflar kalıtım da vermez.
    - Global ayarlar, hizmet (matematik sınıfı gibi) genellikle yardımcı sınıf, uygulama durumu (oturum
      açık / kapalı), genel veritabanı bağlantıları vb. için kullanılabilir. Gerekmedikçe çok statik sınıf
      üretmemeliyiz, bağımlılığı artırır ve kodun test edilebilirliğini zorlaştırır.
    - Örnek olarak Matematik sınıfı yaptım. Tek bir static string değişkeni verip değerini "Toplama "
      olarak tanımladım. topla statik metodu ise verilen 2 sayıyı toplayıp döndürecek. Bunları örnekte
      görüldüğü üzere sınıf adı üzerinden çağırarak ekrana yazdırdım.
 */

namespace _009.Static_Metod___Değişken___Constructor___Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kedi sınıfındaki static miyavla() metodunu direkt sınıf ismi üzerinden çağırdık
            Kedi.miyavla();
            Console.WriteLine();

            // Araba sınıfındaki static kapiSayisi değişkenini static olduğu için direkt sınıf adı üzerinden
            // atayıp çağırdık.
            Araba a1 = new Araba();
            a1.renk = "Sarı";
            a1.motorGucu = 1.8;
            Araba.kapiSayisi = 4;   // Sınıf üzerinden direkt atama
            Console.WriteLine("- ARABA ÖZELLİKLERİ -");
            Console.WriteLine("Rengi      : " + a1.renk);
            Console.WriteLine("Motor Gücü : " + a1.motorGucu);
            Console.WriteLine("Kapı Sayısı: " + Araba.kapiSayisi);    // Sınıf üzerinden direkt çağırma

            Console.WriteLine();

            // Ogrenci sınıfının statik constructoru, okul adını "İncirli Lisesi" olarak atıyor
            Ogrenci o1 = new Ogrenci(27, "Meriç Durmaz", 14);
            
            // Ancak ilk nesneden sonra tekrar çalışmıyor, okulAdi="İncirli Lisesi" olarak kaldı.
            Ogrenci o2 = new Ogrenci(128, "Serap Balta", 13);
            o1.yazdir();
            o2.yazdir();

            // Static Matematik sınıfından string değeri "Toplama " olan a ile statik metoda
            // gönderdiğimiz 5 ile 9'u toplatıp sonucu yazdırdık.
            Console.WriteLine(Matematik.a + "isleminin sonucu: " + Matematik.topla(5, 9));

            Console.ReadKey();



        }
    }
}
