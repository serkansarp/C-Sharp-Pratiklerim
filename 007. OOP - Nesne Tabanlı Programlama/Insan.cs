using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007.OOP___Nesne_Tabanlı_Programlama
{
    internal class Insan
    {

        // Encapsulated parameters
        private string isim;
        private int yas;
        private int kilo;
        private string meslek;
        private int maas;

        // * Yeni: maas özelliğine ulaşmak için property (snippet: prop-tabx2)
        // maas değişkenine get ve set'i içinde olan, ama ondan farklı isimde bir yöntem.
        // Public olması dışarıdan kullanılabilmesini sağlar. _maas isimli property burada
        // dışarıdan _maas set edildiğinde maas'a değer atar, get edildiğinde yine maas
        // değerini yazdırır. Ancak property'nin adı set ve get ettiği değerden farklı olmalıdır
        // yoksa döngüye girer. Tek tek getter setter yazmaktan daha kullanışlı görünüyor.
        public int _maas
        {
            get // değer _maas olarak çağırıldığında bu blok çalışır
            {
                return maas;
            }
            set // _maas = 3000 şeklinde atandığında set bloğu çalışır. 
            {
                maas = value;
            }
        }

        // Constructor (snippet: ctor-tab-tab)
        public Insan(string isim, int yas, int kilo, string meslek, int maas)
        {
            this.isim = isim;       // Dikkat: this-> değil this. şeklinde.
            this.yas = yas;
            this.kilo = kilo;
            this.meslek = meslek;
            this.maas = maas;
        }

        // SETTERS
        public void setIsim(string isim) { this.isim = isim; }
        public void setYas(int yas) { this.yas = yas; }
        public void setKilo(int kilo) { this.kilo = kilo; }
        public void setMeslek(string meslek) { this.meslek = meslek; }

        // GETTERS
        public string getIsim() { return isim; }
        public int getYas() { return yas; }
        public int getKilo() { return kilo; }
        public string getMeslek() { return meslek; }


        public void print()   // await kullanabilmek için asenkron anahtar kelimesini kullanmamız lazım
        {
            Console.WriteLine("Kişinin İsmi   : " + isim);
            Console.WriteLine("Kişinin yaşı   : " + yas);
            Console.WriteLine("Kişinin kilosu : " + kilo);
            Console.WriteLine("Kişinin mesleği: " + meslek);
            Console.WriteLine("Kişinin maaşı  : " + maas);
        }
    }
}
