using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014.Dosya_İşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Belirtilen klasördeki dosyayı açma ya da yoksa yenisini yaratma
            FileStream fs = new FileStream("d:\\tmp\\yeni_dosya.txt", FileMode.OpenOrCreate, FileAccess.Write);

            // fs nesnesine veri yazmak için ise StreamWriter nesnesi oluşturduk ve yazdık.
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Standart bir başlangıç ile");
            sw.WriteLine(" Hello, World! yazdık.");
            sw.WriteLine("Yeni satır için WriteLine.");
            sw.Close(); // Mutlaka kapatılmalıdır.

            // Dosyadan okumak için StreamReader nesnesi kullanmamız lazım.
            string dosya = "d:\\tmp\\yeni_dosya.txt";   // Dosya yolunu 'dosya' isimli string değişkenine atadık.
            StreamReader sr = new StreamReader(dosya);  // ki burada işleri kolaylaştıralım.
            string ilkSatir=sr.ReadLine();
            string kalanSatirlar=sr.ReadToEnd();
            sr.Close(); // ve sr nesnesini de mutlaka kapatıyoruz.

            Console.WriteLine(ilkSatir);
            Console.WriteLine(kalanSatirlar);

            Console.ReadKey();
        }
    }
}
