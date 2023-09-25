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
•   
•   
•   
•   
•   
•   
•   
•   
•   
•   
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
            Console.WriteLine("Rengi      : "+a1.renk);
            Console.WriteLine("Motor Gücü : "+a1.motorGucu);
            Console.WriteLine("Kapı Sayısı: "+Araba.kapiSayisi);    // Sınıf üzerinden direkt çağırma
            
            Console.WriteLine();

            Ogrenci o1=new Ogrenci(27,"Meriç Durmaz",14);
            Ogrenci o2 = new Ogrenci(128, "Serap Balta", 13);
            o1.yazdir();
            o2.yazdir();




            Console.ReadKey();



        }
    }
}
