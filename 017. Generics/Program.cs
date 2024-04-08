using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "1", "2", "3", "4" };
            char[] chars = { 'a', 'b', 'c', 'd' };
            int[] ints = { 2, 3, 5, 7, 11, 13 };
            double[] doubles = { 1, 1.5, 2.5, 3.5, 5.5, 6.7 };

            ShowThemToMe(strings);
            ShowThemToMe(chars);
            ShowThemToMe(ints);
            
            Console.ReadKey();
        }

        // Instead of commented method below, I can use Generics for all data types including classes.
        public static void ShowThemToMe <T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



        /*
        public static void ShowThemToMe(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        */
    }
}
