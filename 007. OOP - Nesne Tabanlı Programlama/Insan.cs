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

        // Constructor (snippet: ctor-tab-tab)
        public Insan(string isim, int yas, int kilo, string meslek)
        {
            this.isim = isim;       // Dikkat: this-> değil this. şeklinde.
            this.yas = yas;
            this.kilo = kilo;
            this.meslek = meslek;
        }

        // SETTERS
        public void setIsim(string isim) { this.isim = isim; }
        public void setYas(int yas) {  this.yas = yas; }
        public void setKilo(int kilo) {  this.kilo = kilo; }
        public void setMeslek(string meslek) {  this.meslek = meslek;}

        // GETTERS
        public string getIsim() { return isim; }
        public int getYas() {  return yas; }
        public int getKilo() {  return kilo; }
        public string getMeslek() {  return meslek; }


        public async void print()   // await kullanabilmek için asenkron anahtar kelimesini kullanmamız lazım
        {
            Console.WriteLine("Kişinin İsmi   : " + isim);
            Console.WriteLine("Kişinin yaşı   : " + yas);
            Console.WriteLine("Kişinin kilosu : " + kilo);
            Console.WriteLine("Kişinin mesleği: " + meslek);
        }
    }
}
