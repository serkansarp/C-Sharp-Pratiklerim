using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*
- Reflection
•   Çalışan program içerisindeki türler hakkında bilgi verir, sorunların çözümünde kullanılır.
•   Attribute'ler ile kullanımı birçok kolaylık sağlayıp koda, hatta kodlayana yeni yetenekler ekler.
•   Type[] ise reflection ile kullanılan, program runtime'ında çalışan işlem ve metotlara dinamik olarak
    ulaşmayı sağlayan bir dizi türüdür.
 */
namespace _042.Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Assembly asm = Assembly.GetExecutingAssembly(); // Çalışan programı nesne olarak al
            Console.WriteLine(asm);                         // Bilgilerini yazdır
            Console.WriteLine();

            // Type[] ile çalışan türleri alıp foreach ile yazdırabiliriz. Type[] normal diziden farklıdır.
            // .Net içerisinde System.Type türünde farklı değişkenler (int, string, double vb.) alır. 
            Type[] types = asm.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine(t.FullName);
            }


            Console.ReadKey();
        }
    }
}
