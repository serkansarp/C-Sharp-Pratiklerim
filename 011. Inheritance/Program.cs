using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 011. Inheritance
•   Projemize Vatandas ve Calisan isimli 2 sınıf ekliyoruz.
•   Calisan sınıfı isimSoyisim ve dogumYili bilgilerini alıyor.
•   Vatandas ise sadece tcKimlik bilgisi istiyor.
•   Vatandas sınıf isminin devamına : Calisan eklediğimizde, yani Vatandas : Calisan
    şeklinde yazdığımızda Vatandas sınıfının Calisan'dan inheritance alabileceğini,
    Vatandas sınıfını Calisan sınıfı ile genişlettiğimizi, Vatandas'ın Calisan'ın
    özellik ve metodlarını kullanabileceğini belirtmiş oluyoruz.
•   Vatandas vatandas1 ile yeni nesnemizi oluşturduğumuzda, aslında Vatandas sınıfında
    olmayan tcKimlik ve dogumYili özelliklerini de ekleyebiliyoruz.
•   bilgileriYazdir metodu yine Calisan içerisinde ama onu da vatandas1 nesnesi üzerinden
    kullanabiliyoruz (tcKimlik özelliği hariç, çünkü Calisan sınıfı Vatandas'tan kalıtım
    alamıyor. Onu da kendi sınıfındaki tcKimlikGoster metoduyla yazdırıyoruz.
 */

namespace _011.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            vatandas1.tcKimlik = "12345678901";
            vatandas1.dogumYili = 1999;
            vatandas1.isimSoyisim = "Serkan Sarp";

            vatandas1.bilgileriYazdir();
            vatandas1.tcKimlikYazdir();

            Console.ReadKey();

        }

    }
}
