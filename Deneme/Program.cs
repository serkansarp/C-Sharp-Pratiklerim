using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
            degistir(ref a);
            Console.WriteLine(a);

            Console.ReadKey();
        }

        public static void degistir(ref int x)
        {
            x = x * x;
        }

    }

    

}
