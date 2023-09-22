using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 008. TC Kimlik Numarası Çoklu Kontrol
•   Bu kodda bazı tooltipleri göreceğiz.
•   Kullanıcıdan aldığımız TC Kimlik Numarasının geçerli olup olmadığını kontrol ediyoruz.
•   İlk şartımız 11 haneli olması. String olarak aldığımız için is
•   
•   
•   
•   
•   
•   
 */
namespace _008.TC_Kimlik_Numarası_Çoklu_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen TC Kimlik Numaranızı Girin: ");
            string tckimlik = Console.ReadLine();

            bool a = true;
            char b;
            long _tckimlik;
            int onHaneToplam=0;

            // Bütün karakterler sayı mı kontrolü
            if (long.TryParse(tckimlik, out _tckimlik) == true)
            {
                // 11 haneli mi kontrolü
                if (tckimlik.Length == 11)
                {
                    // 10 hane toplamının 10'a bölümünden kalan son karakter mi kontrolü
                    for (int i = 0; i < tckimlik.Length - 1; i++)
                    {
                        Console.WriteLine(Convert.ToInt32(tckimlik[i]));
                    }
                    // ub - önce char'a çevirmemiz gerekiyor
                        if (onHaneToplam%10== Convert.ToInt
                    {
                        Console.WriteLine("357");
                    }
                    else
                    {
                        Console.WriteLine("Baştaki 10 hanenin toplamının son rakamı 11'inci haneyle eşleşmiyor!");
                    }


                    //40633024912

                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı 11 karakter değil!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı karakter kullandınız!");
            }


            pause();
        }
        static void pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
