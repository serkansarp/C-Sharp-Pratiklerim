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
                int a = 25;
                int b = 0;  // Sıfırdan başka bir değer için program çalışır, catch'e girilmeden finally'e gidilir.
                int c = a/b;
            }
            
            // Try'da hata olduğunda çalıştırılacak blok
            catch
            {
                Console.WriteLine("Sıfıra bölünme hatası!");
                sorun = true;
            }
            
            // Zorunlu olmayan kısım
            finally
            {
                if (sorun == true)
                    Console.WriteLine("Sorun ortaya çıktı.");
                else
                    Console.WriteLine("İşlem başarıyla tamamlandı.");
            }


            Console.ReadKey();
        }
    }
}
