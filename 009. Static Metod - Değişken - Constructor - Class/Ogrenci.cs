using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009.Static_Metod___Değişken___Constructor___Class
{
    internal class Ogrenci
    {
        private int no { get; set; }
        private string adSoyad { get; set; }
        private int yas { get; set; }
        private static string okulAdi { get; set; }

        static Ogrenci()
        {
            okulAdi = "İncirli Lisesi";
        }

        public Ogrenci(int no, string adSoyad, int yas)
        {
            this.no = no;
            this.adSoyad = adSoyad;
            this.yas = yas;
        }

        public void yazdir()
        {
            Console.WriteLine("- ÖĞRENCİNİN -");
            Console.WriteLine("Okul Adı   : " + okulAdi);
            Console.WriteLine("Numarası   : " + no);
            Console.WriteLine("Adı, Soyadı: " + adSoyad);
            Console.WriteLine("Yaşı       : " + yas);
        }

    }
}
