using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;
using System.Xml;

namespace Deneme
{
    internal class Program
    {
        



        static void Main(string[] args)
        {

            Liste tyList = new Liste();

            tyList.sonaEkle(10);
            tyList.sonaEkle(20);
            tyList.sonaEkle(30);

            tyList.basaEkle(5);

            tyList.yazdir();

            Console.ReadKey();
        }
    }
}
