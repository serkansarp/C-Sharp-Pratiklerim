using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _999.Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // konsoldan ya da grafikle bir lcd saat


            String a = "Merhaba<1> Nasılsın";
            temizle(a);

            //string içinden < ile başlayan ve > ile sonlanan aralığı temizle, yani <1> veya <2> ya da <selam> gibi
            //yapılan işlem sonucunda "Merhaba Nasılsın" çıktısını almalıyız.
            //string içinde birden fazla <1> olabilir, hepsini temizlemeliyiz.
            //string içinde <1> olmayabilir, bu durumda stringin aynısını geri döndürmeliyiz.
            //string içinde <1> olabilir, ama > olmayabilir, bu durumda stringin aynısını geri döndürmeliyiz.
            // bu kodu yazar mısınız?







            Console.ReadKey();

        }
        //fibonacci hesaplama metotu
        public static void temizle(String a)
        {
            a = a.Replace("<1>", "");
            Console.WriteLine("Yeni: "+a);
        }

    }
}