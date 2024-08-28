using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fakt(19));
            

            Console.ReadKey();
        }

        static int fakt(int x)
        {
            if (x == 5)
                return 15;
            else
                return x + fakt(x - 1);

        }

    }
}
