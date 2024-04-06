using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Output_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 81;
            Console.Write("Sayi={0,10:F2}",sayi);
            Console.Write(" - Console.Write(\"Sayi={0,10:F2}\",sayi) koduyla toplam 10 satır yazmasını sağladık.");



            Console.ReadKey();
        }
    }
}
