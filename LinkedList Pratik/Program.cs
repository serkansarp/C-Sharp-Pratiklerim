using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Pratik
{
    class Dugum
    {
        public int deger;
        public Dugum sonraki;

        public Dugum(int deger)
        {
            this.deger = deger;
            sonraki = null;
        }
    }

    class Liste
    {
        public Dugum ilk;

        public Liste()
        {
            ilk = null;
        }

        public void sonaEkle(int deger)
        {
            Dugum eleman = new Dugum(deger);

            if (ilk == null)
            {
                ilk = eleman;
                Console.WriteLine("liste boş olduğundan ilk eleman olarak eklendi.");
            }
            else
            {
                ilk.sonraki= eleman;
                Console.WriteLine("Öncekine ek düğüm eklendi");
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dugum d1 = new Dugum(5);
            Dugum d2 = new Dugum(10);

            d1.sonraki = d2;

            Console.WriteLine(d1.deger);
            Console.WriteLine(d2.deger);
            Console.WriteLine(d1.sonraki.deger);

            Console.ReadKey();
        }
    }
}
