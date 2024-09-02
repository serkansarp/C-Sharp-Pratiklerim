using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024.Genişletme_Metodları___Extention_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "selaM, nasIlSın?";
            Console.WriteLine("Orijinali:\n"+a);
            a = a.IlkHarfiBuyut();
            Console.WriteLine("Düzenlenmişi:\n"+a);
            

            Console.ReadKey();
        }
    }

    static class StringGenisletme    // Static sınıf içinde olmalı ve bu yüzden tüm üyeleri de static.
    {
        public static string IlkHarfiBuyut(this string a)   // this ve public static ile yazılmalıdır.
        {
            if (string.IsNullOrEmpty(a))    // Stringin boş olup olmadığına bakıp boşsa kendisini geri döndürür.
                return a;
            else
                return char.ToUpper(a[0]) + a.Substring(1).ToLower(); // İlk harfi büyütüp gerisini küçültüp, birleştirip döndürür.
            
        }
    }
}
