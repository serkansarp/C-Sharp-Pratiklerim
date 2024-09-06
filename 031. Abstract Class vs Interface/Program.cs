using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- Abstract Class vs Interface -
Interface konusunda baştaki yorum bölümünde temel farklarına değinmiştik. Bunlar;
• Interface üyeleri erişim belirleyici almaz, otomatik olarak publictir ama public de yazdırmaz.
  Abstract classlar erişim belirleyici alır.
• Abstract classların içlerinde çalışan kodlar/namespaceler bulunabilir, interface'te prototip gibi yazılır.
• İkisi sınıf da implemente edileceği için sealed almaz, zaten mantıksızdır.

Üsttekilere ek olarak;
• Abstract sınıflar, interface'e göre daha hızlıdır. Çünkü metot imzaları, metot çağrı biçimleri, interface'lerin
  çoklu kalıtıma izin vermesi vb. nedenler, interface'lere ekstra yük getirir. Örnekli detaylar ise:
• Bir sınıf, interface'lerden multi-inheritance yapabilir. Abstract/Classlardan tek inheritance yapabilir.
• Bu durum birlikte kullanılabilir ancak inherit edilecek tek sınıf başa, diğerleri ondan sonra yazılır.
• Abstract sınıfların özellikleri, metotları override edilerek alınır, interface direkt alınır/implement edilir.

Not: Runtime error verecek satırlar yoruma alınmıştır. Kendi denemek isteyen başlarındaki // karakterlerini silip
kendi derleyicilerinde, editörlerinde aldıkları hatayı araştırabilir.
*/

namespace _031.Abstract_Class_vs_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme1 d1 = new Deneme1();
            d1.yaz1();
            Deneme3 deneme3 = new Deneme3();
            deneme3.yaz2();
            
            Console.WriteLine("\nKonsol çıktısı, örneği anlamak için yetersizdir, interface ve class kodlarını incelemeniz önerilir.");
            Console.ReadKey();
        }
    }

    class Deneme1:Abst1   // Tek sınıftan kalıtım alınabilir (Single inheritace).
        {
            public override void yaz1() // * Abstract sınıftan alınan metot override edilerek alınmalıdır.
            {
                Console.WriteLine("Deneme1: Abst1'den alınan override edilmiş yaz1");
            }
    } 
    
    // class Deneme2:Abst1,Abst2 { }    // Compile error verir, sınıflarda başka sınıflardan multi-inheritance yoktur.
    
    class Deneme3: IInter1, IInter2 // Multi interface inheritance yapılabilir.
    {
        public void yaz2()   // * Interface'ten alınan kod direkt alınabilir, override gerekmez.
        {
            Console.WriteLine("Deneme3: Interface'ten override'sız alınan yaz2 metodu");
        }
    }  
    // class Deneme4 : IInter1, IInter2, Abst1 { }  // Multi-inheritance içerisinde interfaceler + 1 sınıf alabilir ama başta yazılması gerekir.
    class Deneme5 : Abst2, IInter1, IInter2 // Üst satırın düzeltilmiş versiyonu
    {
        
        public void yaz2()
        {
            Console.WriteLine("Deneme5: Interface'ten override'sız alınan yaz2 metodu");
        }
    }


    // Deneme amaçlı sınıf ve interfaceler
    abstract class Abst1
    {
        public abstract void yaz1();
    }
    abstract class Abst2 {  }
    interface IInter1 { }
    interface IInter2 { void yaz2(); }

}
