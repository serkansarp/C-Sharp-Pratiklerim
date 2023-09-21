using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007.OOP___Nesne_Tabanlı_Programlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan1 = new Insan("Sinan",45,80,"Berber");
            insan1.print();

            insan1.setIsim("Mahmut");
            insan1.setYas(58);
            insan1.setKilo(92);
            insan1.setMeslek("Ayakkabı Satıcısı");

            Console.WriteLine();
            insan1.print();



            Console.ReadKey();
        }
    }
}
