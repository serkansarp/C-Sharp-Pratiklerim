using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025.Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi duman = new Kedi();
            duman.Ses();



            Console.ReadKey();
        }
    }

    class Hayvan
    {
        // Ana metod 'virtual' ile belirtilir
        public virtual void Ses()
        {
            Console.WriteLine("-");
        }
    }

    class Kopek:Hayvan
    {
        // Ezilen metod ise override ile belirtilir.
        // Not: Daha önce 'Metod Gizleme' konusunda new keywordü ile benzer bir pratiğimiz oldu.
        // Aralarındaki fark polymorphism pratiğinde işledik.
        public override void Ses()
        {
            Console.WriteLine("Hav hav");
        }
    }

    class Kedi:Hayvan
    {
        public override void Ses()
        {
            Console.WriteLine("Miyav");
        }
    }

}
