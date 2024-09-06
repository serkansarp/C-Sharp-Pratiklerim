using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028.Partial  /*  Büyük projelerde, sınıfı (hatta metodu) parçalamaya yarar, kod okunabilirliğini artırır.
                            Ayrıca metot parçalamaya da yarar ancak private metot olur. Ayrıca bu metotlar ref alır,
                            out almazlar. (*ref'i önceden hatırlayalım, ref ile fonksiyona geçirilen özelliğin değerini
                            dışarıda da değiştirir, fonksiyondan sonra kendisini çağırdığımızda (örn. int a),
                            fonksiyonda değişikliğe uğramış hali olarak gelir. Örnek çalışmada kullanılmadı. */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a=new A();
            a.Yaz1();
            a.Yaz2();

            a.GetSelamVer();

            Console.ReadKey();

        }
    }

    // Parçaların tümünün başına 'partial' keywordü ve aynı sınıf ismiyle yazılır, tamamı tek sınıf olarak çalışır.
    partial class A
    {
        public void Yaz1()
        {
            Console.WriteLine("Sınıfın ilk parçasındaki Yaz1 metodu.");
        }

        // Metod parçalama
        partial void SelamVer();    // C'deki .h dosyalarına yazılan prototip gibi burada belirttik.


    }
    
    // Ek olarak, parçalardan herhangi birini sealed, static vb. yaparsak diğeri de otomatik olarak aynı özelliği alır.
    partial class A 
    {
        public void Yaz2()
        {
            Console.WriteLine("Sınıfın ikinci parçasındaki Yaz2 metodu.");
        }

        partial void SelamVer() // Ancak private olurlar, get-set mantığıyla dışarıdan çalıştırılabilirler.
        {
            Console.WriteLine("Selam");
        }

        public void GetSelamVer()   // Getterla çağırıp public belirteciyle dışarıdan kullanabiliriz.
        {
            SelamVer();
        }

    }

}
