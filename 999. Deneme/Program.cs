using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _999.Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Microsoft SQL Express'e bağlantı kur
            // - Veri çekip göster
            // - Düzenli yap, sayısını uzunluğunu düzenle.
            // - SQLite ile ekleme çıkarma, bağlantı, gösterme vb.
            // - Yeni dönem başladı :| Kod yazamıyorum.

            string[] soru = {
            "Java nedir?",
            "Java yılı?",
            "Java'nın yazılımcısı kimdir?",
            "JavaScript nedir?",
            "JavaScript yılı?",
            "Objective-C nedir?",
            "Objective-C'yi kim kullanmaktadır",
            "Swift nedir?",
            "Swift'i kim kullanmaktadır?",
            "Python nedir?",
            "Python yılı?",
            "Kotlin nedir?",
            "Kotlin yılı?",
            "Kotlin kim tarafından yaratılmıştır?",
            "Scala nedir?",
            "Scala online derleyicisinin adı nedir?",
            "Dart nedir?",
            "Dart'ı kim desteklemektedir?",
            "Dart hangi platformda çalışmaktadır?",
            "Ruby nedir?",
            "Ruby yılı?",
            "Ruby'i kim yazmıştır?",
            "Rust nedir?",
            "Rust yılı?",
            "Rust'ı kim desteklemektedir?",
            "Lua nedir?",
            "Lua'yı kim yazmıştır?",
            "PHP nedir?",
            "PHP yılı?",
            "Solar 2D nedir?",
            "Solar 2D'nin eski adı nedir?",
            "Solar 2D ile hangi dilde yazılım yapılır?",
            "Solar 2D'yi kim yazmıştır?",
            "Flutter nedir?",
            "Flutter yılı?",
            "Flutter'ın destek dili nedir?",
            "Flutter'ı kim desteklemektedir?",
            "Apache Cordova nedir?",
            "Apache Cordova'nın eski adı nedir?",
            "Apache Cordova yılı?",
            "Codename One nedir?",
            "Codename One yılı?",
            "Codename One'ı kim desteklemektedir?",
            "React Native nedir?",
            "React Native yılı?",
            "React Native'i kim desteklemektedir?",
            "Qt nedir?",
            "Qt kim tarafından yazılmıştır?",
            "Appery.io nedir?",
            "Appery.io yılı?",
            "Appery.io kim desteklemektedir?",
            "Google Playstore'un eski adı nedir?",
            "Google Playstore bu isme hangi yıl geçiş yapmıştır?",
            "Google Playstore hangi yıl çıkmıştır?",
            "Appstore hangi yıl çıkmıştır?",
            "Huawei Appgallery hangi yıl ortaya çıkmıştır?",
            "Huawei Appgallery sadece Huawei cihazlara mı destek verir?",
            "Huawei Appgallery hangi ülkede, kaç yılında ortaya çıkmıştır?",
            "Huawei Appgallery dünyaya kaç yılında açılmıştır?",
            "Amazon Appstore hangi yıl ortaya çıkmıştır?",
            "Amazon Appstore'da hangi işletim sistemi için uygulamalar bulunur?",
            "Microsoft Store yılı?",
            "JVM kullanan diller hangileridir?",
            "Google'ın desteklediği dil ve platform hangisidir?",
            "Sencha EXT JS nedir?",
            "Sencha EXT JS'in eski adı nedir?",
            "Fortune 100 şirketlerinin %60'ının kullandığı çerçeve hangisidir?"
            };


            string[] cevap = {
            "Dil",
            "1995",
            "James Gosling - Sun > Oracle",
            "Dil",
            "1995",
            "Dil",
            "Apple",
            "Dil",
            "Apple",
            "Dil",
            "1991",
            "Dil",
            "2011",
            "JetBrains",
            "Dil",
            "Scastie",
            "Dil",
            "Google",
            "Flutter",
            "Dil",
            "1995",
            "Yukihito Matsumoto",
            "Dil",
            "2010",
            "Mozilla Vakfı",
            "Dil",
            "PUC-Rio",
            "Dil",
            "1995",
            "Platform",
            "Corona SDK",
            "Lua",
            "Vlad Shcerban",
            "Platform",
            "2017",
            "Dart",
            "Google",
            "Platform",
            "PhoneGap",
            "2009",
            "Platform",
            "2007",
            "Sun-Oracle mobil geliştiriciler",
            "Platform",
            "2015",
            "Meta",
            "Platform",
            "The Qt Company",
            "Platform (Düşük kodlu, sürükle bırak)",
            "2012",
            "Exadel",
            "Android Market",
            "2012",
            "2008",
            "2008",
            "2011",
            "Hayır, Honor'lar için de uygulama bulundurur.",
            "Çin, 2011",
            "2018",
            "2011",
            "Android",
            "2012",
            "Kotlin ve Scala",
            "Dart - Flutter",
            "Neredeyse tüm JS kütüphanelerini barındıran platform/çerçeve.",
            "Sencha Touch",
            "Sencha Ext JS"
            };

            Random rnd = new Random();
            int sayi = 0;
            string devam = "y";
            int sayac = 1;
            
            while (devam == "y")
            {
                

                for (int i = 0; i < 10; i++)
                {

                    sayi = rnd.Next(soru.Length);
                    Console.WriteLine(sayac + ". " + soru[sayi]);
                    Console.ReadKey();
                    Console.WriteLine(cevap[sayi]);
                    sayac++;
                }

                Console.Write("Devam etmek istiyor musunuz (y/n): ");
                devam = Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
