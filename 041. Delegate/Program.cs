using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- Delegate (Delege, Temsilci)
•   Metotları temsil ederler, bu sayede metotları değişkene atayıp sonra çağırabiliriz.
•   Eventlerle daha ilişkilidir. Eventleri henüz işlemedik. GUI üzerinde daha çok karşımıza çıkan
    "fare sol tuşuna çift tıklandı, butona tıklandı" işlemleri eventtir. Bu durumda programın ne
    yapacağını belirleriz. Ancak şimdi sadece delegate konusuna eğiliyoruz.
•   Asenkron programlamada da bir işlem bittikten sonra yeni bir işlemin/metodun çağırılması için
    kullanıyoruz.
•   Delegateler main'den önce tanımlanır ve içerisine refere edeceği metotların şablonları girilir.
•   Delegate referans tipli olduğundan main'de bir nesne oluşturulur ve onun üzerinden metotlar çağırılır.
•   İstenirse yeni metotlar da içine eklenebilir, sırasıyla sonuçlarını yazdırır.
•   Yalnız metotlarda return işlemi varsa sonuncuyu görebiliriz. yield keywordü ise bir iterasyon
    olmadığı için işe yaramaz.
 */
namespace _041.Delegate
{
    internal class Program
    {
        
        delegate void Rectangle(double _a, double _b);    // Dikdörtgenle ilgili alan ve çevre hesapları yapacak delegate

        static void Main(string[] args)
        {
            // Rectangle test = area;                   // Bu şekilde de kullanabiliriz. Ama nesne mantığıyla yaptık.
            Rectangle test = new Rectangle(area);       // Alanı hesaplayacak metodu nesneye ekledik.
            test += perimeter;                          // Çevre hesaplayıcı metodu da bu şekilde ekledik.
            
            test(3.2, 5.3);                             // İki metodu sırayla çalıştırıp sonuç getirecek.
            

            Console.ReadKey();
        }
 
        // Dikdörtgen alan ve çevresini hesaplayan 2 metot
        static void area(double a, double b)        // Area = Alan
        {
            Console.WriteLine("Dikdörtgenin alanı:\t"+a*b);
        }

        static void perimeter(double a,double b)    // Perimeter = Çevre
        {
            Console.WriteLine("Dikdörtgenin çevresi:\t"+2 * (a + b));
        }
    }
}
