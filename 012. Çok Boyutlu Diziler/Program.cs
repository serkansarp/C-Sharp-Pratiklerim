using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 012. Çok Boyutlu Diziler
•   ikiBoyutluDizi için satır ve sütun numaralarından faydalanıyoruz, saymaya sıfırdan başlıyoruz.
•   Önce 1. indisin 2. indisine denk gelen -6 çıktısını alıyoruz.
•   ucBoyutluDizi için de bloklardan faydalanıyoruz, aslında ikiBoyutluDizi de aynı şekilde çalışıyor.
•   Daha rahat görebilmek için blok blok, satır satır ayırılmış şekilde yazdık. Asıl yapısı küme içerisinde
    küme içerisinde küme şeklindedir. Küme sayısı artırılarak daha fazla boyutlu diziler de yaratılabilir.
•   1,2,2 ile ise ortadaki bloğun son satırının en sonundaki 20 sayısını yazdırıyoruz.
 */

namespace _012.Çok_Boyutlu_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // [,] iki sayıyı birbirinden ayırıyor gibi düşünebiliriz, gerekirse değer de girilebilir.
            int[,] ikiBoyutluDizi = {   { 5, 8, 2 },
                                        { 13, 24, -6 } };

            int[,,] ucBoyutluDizi = { { { 3, 4, 5 },
                                        { 6, 7, 8 },
                                        { 9, 10, 11 } },
                                            {   {12, 13, 14 },
                                                {15, 16, 17 },
                                                {18, 19, 20 } },
                                                    {   {21,22,23 },
                                                        {24,25,26 },
                                                        {27,28,29 } }
                                                                        };

            Console.WriteLine(ikiBoyutluDizi[1, 2]);
            Console.WriteLine(ucBoyutluDizi[1, 2, 2]);

            Console.ReadKey();
        }
    }
}
