using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023.Try_Catch_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool sorun = false;

            // Try yani denenecek kodların çalıştırılacağı blok
            try
            {
                Console.Write("Bölünecek sayıyı giriniz: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Bölen sayıyı giriniz: ");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;

            }
            
            // Try'da oluşan hataya göre çalışacak catch bölümleri
            catch(DivideByZeroException)    // Sıfıra bölünme hatası
            {
                Console.WriteLine("Sıfıra bölünme hatası!");
                sorun = true;
            }

            catch (OverflowException)    // Int için çok büyük bir sayı (byte sınırlarından yüksek)
            {
                Console.WriteLine("Programın byte sınırından yüksek sayı girişi yapıldı!");
                sorun = true;
            }

            catch(FormatException)  // Int dışı bir veri girildiğinde
            {
                Console.WriteLine("Lütfen sayı değerleri giriniz");
                sorun = true;
            }

            catch    // Herhangi diğer bir hata için
            {
                Console.WriteLine("Programın byte sınırından yüksek sayı girişi yapıldı!");
                sorun = true;
            }


            // Finally, zorunlu bir blok değil, hata yakalasak da, yakalamasak da çalışır.
            // Sadece ekrana yazı yazdırmak değil, diğer işlemler için kullanılır. Örneğin
            // T-SQL ile bağlantı kurduğumuzda, bağlantının kapatılması gerekir. Hata olsa da,
            // olmasa da bağlantının kapatılması için kullanılabilir. "Sonuçta" anlamıyla direkt
            // Türkçe'ye çevirmek ve öyle anlamak yanlış bir yaklaşımdır.
            finally
            {
                if (sorun == true)
                    Console.WriteLine("Beklenmeyen Hata!");
                else
                    Console.WriteLine("İşlem başarıyla tamamlandı.");
            }


            Console.ReadKey();
        }
    }
}
