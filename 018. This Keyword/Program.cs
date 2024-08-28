using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _018.This_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif nesne = new Sinif(5, 45, 12);
            Console.WriteLine(nesne.x);
            Console.WriteLine(nesne.y);
            Console.WriteLine(nesne.z);

            Console.ReadKey();
        }
    }


    class Sinif
    {
        public int x;
        public int y; 
        public int z;
                
        // Parametreli Constructor
        public Sinif(int x)
        {
            this.x = x;  // x = x anlam ifade etmez, nesnenin x'ine parametredeki x'i atamak için this kullanıyoruz.
        }

        // Ezici Constructor (x'i, sondaki :this(x) ile ilk constructorı çalıştırarak alıyoruz.
        public Sinif(int x,int y,int z):this(x)
        {
            this.y = y;
            this.z = z;
        }

        


    }

    


}
