using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
- Interface - 
Abstract sınıflarla aynı mantıkla kullanılırlar. Erişim belirleyicileri otomatik olarak publictir,
kendimiz tekrar yazmayız. İçlerinde çalışan kod yoktur, Sadece tanım bulunur, prototip gibi düşünebiliriz.
Ancak abstract class kod alabilir. 

Sınıf gibi referans tiplidir. Field da tanımlanmaz, prop tanımlanabilir (ancak yine başına public, private vb. almaz,
static de almaz, mutlaka implemente edileceği için interface'in kendisi sealed de almaz).
Ancak abstract class üyeleri erişim belirleyicisi kullanabilir.

Daha ince detaylar bir sonraki projede.
*/

namespace _030.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ISelam s = new ISelam();     // Interface'ten nesne alamayız ancak,
            ISelam ayse1 = new Ayse();      // polymorphism kullanabiliriz. Bu durumda Ayse sınıfın metodunu çalıştıracak.
            ISelam ali1 = new Ali();    // Bu nesne ise Ali sınıfından oluşturulduğundan onun içindeki metotlarla ilgilenir.

            ayse1.SelamVer();
            ali1.SelamVer();

            // Polymorphism kullanmadan ise MetotSelam metodundaki interface parametresine nesnemizi geçirebiliriz.
            Ali ali2 = new Ali();
            MetotSelam(ali2);   // ali2 nesnesini geçirdiğimiz için yine Ali'ye selam verecektir.

            Console.ReadKey();
        }

        static void MetotSelam(ISelam a)
        {
            a.SelamVer();
        }

    }
        
    class Ali : ISelam
    {
        public void SelamVer()
        {
            Console.WriteLine("Selam Ali!");
        }
    }

    class Ayse : ISelam
    {
        public void SelamVer()
        {
            Console.WriteLine("Selam Ayşe!");
        }
    }

    interface ISelam    // Genel bir prensip olarak başına I eklenir, kodun okunurluğunu kolaylaştırır.
    {
        void SelamVer();
    }

}
