using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Das_Heimweh_Enum_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = {
                "0", "adana", "adıyaman", "afyon","ağrı","amasya","ankara","antalya","artvin","aydın","balıkesir",
                "bilecik","bingöl","bitlis","bolu","burdur","bursa","çanakkale","çankırı","çorum","denizli",
                "diyarbakır","edirne","elazığ","erzincan","erzurum","eskişehir","gaziantep","giresun","gümüşhane","hakkari",
                "hatay","ısparta","içel","istanbul","izmir","kars","kastamonu","kayseri","kırklareli","kırşehir",
                "kocaeli","konya","kütahya","malatya","manisa","kahramanmaraş","mardin","muğla","muş","nevşehir",
                "niğde","ordu","rize","sakarya","samsun","siirt","sinop","sivas","tekirdağ","tokat",
                "trabzon","tunceli","şanlıurfa","uşak","van","yozgat","zonguldak","aksaray","bayburt","karaman",
                "kırıkkale","batman","şırnak","bartın","ardahan","ığdır","yalova","karabük","kilis","osmaniye",
                "düzce"
            };


            Console.WriteLine();
            Console.WriteLine();

            string b = "0";
            Random rnd = new Random();
            int num = rnd.Next(10, 15);
            int dogru = 0;
            int soruSayisi = 20;

            for (int i = 0; i < soruSayisi; i++)
            {
                num = rnd.Next(1, 82);

                Console.Write("{0:D2} : ", num);

                b = Console.ReadLine();

                if (b == sehirler[num])
                {
                    Console.WriteLine("Doğru");
                    dogru++;
                }
                else
                {
                    Console.WriteLine("Yanlış");
                }

            }

            Console.WriteLine("\nOyun Sonu!\nKazanılan Puan: " + dogru * 100 / soruSayisi);


            Console.ReadKey();
        }
    }
}
