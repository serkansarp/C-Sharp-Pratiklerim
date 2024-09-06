using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed___Mühürlü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ana a = new Ana();
            Turemis1 turemis1 = new Turemis1();
            Turemis2 turemis2 = new Turemis2();

            a.Yaz1();
            turemis1.Yaz1();
            turemis2.Yaz1();


            Console.ReadKey();
        }
    }

    class Ana
    {
        public virtual void Yaz1()
        {
            Console.WriteLine("Ana sınıf\tYaz1");
        }
    }

    // Not: sealed class Turemis1 : Ana yaparsak Turemis2'ye kalıtım veremez, mühürlenir.
    class Turemis1 : Ana
    {
        /* public sealed override void Yaz1(): Kendisinden türeyen alt sınıftaki Yaz1 metodunu geçersiz kılar, derlemez */
        public override void Yaz1() // Bu şekilde Turemis2 sınıfındaki Yaz1 metodu da çalışır.
        {
            Console.WriteLine("Turemis1 sınıf\tYaz1");
        }
    }

    class Turemis2 : Turemis1
    {
        public override void Yaz1() // Üst sınıflardan herhangi birinde sealed
        {
            Console.WriteLine("Turemis2 sınıf\tYaz1");
        }
    }

}
