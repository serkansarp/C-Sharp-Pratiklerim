using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Sadece isimSoyisim ve dogumYili bilgilerini aldığımız Calisan sınıfı

namespace _011.Inheritance
{
    internal class Calisan
    {
        public string isimSoyisim { get; set; }
        public int dogumYili { get; set; }

        public void bilgileriYazdir()
        {
            Console.WriteLine("Kişinin;\nAdı-Soyadı  : " + isimSoyisim);
            Console.WriteLine("Doğum Yılı  : "+dogumYili);
        }
    }
}
