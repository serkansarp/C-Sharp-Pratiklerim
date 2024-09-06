using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026.Polymorphism___Çok_Şekillilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ana a = new Ana();
            Turemis t = new Turemis();

            // Üsttekilerden farklı olarak ana sınıftan referans aldık ama nesneyi Turemis sınıftan oluşturduk (Kumanda-Tv mantığı)
            Ana x = new Turemis();
            
            
            /* Turemis y = new Ana();   // Türemiş sınıf referansıyla Ana sınıftan nesne üretilemez. */


            a.Yaz1();
            t.Yaz1();
            x.Yaz1();   // Referansını ana sınıftan aldığı için Ana sınıftaki metodu çalıştırır.
            ((Turemis)x).Yaz1();    // Ancak casting ile yine Türemiş sınıf Yaz1'ine ulaşabiliriz. Çünkü x'i Turemis tipinde aldık.
            
            Console.WriteLine();

            a.Yaz2();
            t.Yaz2();
            x.Yaz2();
            // Yaz2, ana sınıfta virtual (sanal), türemiş sınıfta override (ez)
            // ile belirtildiği için Ana sınıf tamamen görmezden gelinir.
            
            ((Ana)x).Yaz2();    // Ezdiğimiz için Ana türünde x göstersek bile Türemiş Yaz2'si çalışacaktır.
            Console.ReadKey();
        }
    }

    class Ana
    {
        public void Yaz1()  // 2 sınıfta da yaz1 metoduna public void ile başlandığına dikkat edelim.
        {
            Console.WriteLine("Ana sınıf\tYaz1");
        }

        public virtual void Yaz2()  // virtual ile daha sonra geçersiz kılınabileceğini belirttik
        {
            Console.WriteLine("Ana sınıf\tYaz2");
        }
            
    }

    class Turemis : Ana
    {
        public new void Yaz1()  // new ile gizleme yapmamıza rağmen referansı Ana sınıf olduğu için onu çalıştırır.
        {
            Console.WriteLine("Türemiş sınıf\tYaz1");
        }

        public override void Yaz2() // override ile öncekini geçersiz kıldık
        {
            Console.WriteLine("Türemiş sınıf\tYaz2");
        }

    }


}
