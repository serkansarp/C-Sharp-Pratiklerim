using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Indexer
- Indexer'lar (Türkçe: Dizinleyici), nesnenin diziler gibi indekslenebilmesini sağlar.
- Sınıfında yazım şekline dikkat edelim, prop olarak ve this ile belirlenir.
- Nesnelere [] ile ulaşabilir duruma gelip, içerideki verileri dışarıdan dizi mantığıyla kullanabiliriz.
Temel amacı bu olup, sınıf içerisindeki verilere daha kullanıcı dostu bir yaklaşımla erişmemize imkan
tanır.
 
*/

namespace _032.Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyCollection a = new MyCollection();
            a[3] = 5;
            Console.WriteLine(a[3]);    // Set ederken (x+2)*3 dediğimiz için (5+2)*3=21 çıktısını alacağız.

            Console.ReadKey();
        }
    }

    public class MyCollection
    {
        private int[] data = new int[10];

        // Indexer tanımı, property olarak ve this ile yazıldığına dikkat edelim.
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = (value+2)*3; }  // 2 ekleyip toplamın 3 katını set ettik. Normal de yapabilirdik,
            // sadece yapabileceklerimizin görülmesi için bu şekilde yazdım. Yoksa standardı direkt value şeklinde.
        }
    }

}
