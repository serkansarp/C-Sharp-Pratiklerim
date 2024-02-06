using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.Inheritance
{
    internal class Vatandas : Calisan
    {
        public string tcKimlik { get; set; }

        public void tcKimlikYazdir()
        {
            Console.WriteLine("TC Kimlik No: " + tcKimlik.Substring(0, 5) + "******");
        }
    }
}
