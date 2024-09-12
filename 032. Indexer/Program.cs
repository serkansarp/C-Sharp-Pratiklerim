using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set { data[index] = (value+2)*3; }  // Set ederken 2 ekleyip toplamın 3 katını set ettik.
        }
    }

}
