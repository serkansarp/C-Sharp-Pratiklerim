using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dnm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen hesaplanmasını istediğiniz Fibonacci sayısı adımını giriniz: ");

            int adim = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(adim);

            Console.WriteLine(hesapla(1, 1, 1, adim));



            Console.ReadKey();
        }

        public static int hesapla(int i, int j, int k, int l)
        {
            if (k == l - 1)
                return i + j;
            else
                return i + hesapla(j, i + j, k + 1, l);


            //1+1+2+3+5+8

        }
    }




}

