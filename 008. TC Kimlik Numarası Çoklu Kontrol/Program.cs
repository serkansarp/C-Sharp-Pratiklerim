using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 008. TC Kimlik Numarası Çoklu Kontrol
•   Bu kodda bazı tooltipleri göreceğiz.
•   Kullanıcıdan aldığımız TC Kimlik Numarasının geçerli olup olmadığını kontrol ediyoruz.
•   Bunu iç içe if bloklarıyla yapıyoruz, true dönen blok içerisinde bir sonraki kontrole geçiyoruz.
•   1. kontrolümüz bütün karakterlerin rakam olması. int 10 haneden yukarı çıkamadığı için long'a dönüştürmeye
    çalışıyoruz, ki kullanımı şu şekildedir:
    
    long.TryParse(tckimlik, out _tckimlik)

    True dönerse sonraki kontrol.
•   2. kontrolümüz girdinin 11 haneli olması. String olarak aldığımız için

    tckimlik.Length == 11

    if'i ile kolaylıkla ulaşabiliyoruz. String uzunluğuna .Length ile erişilebiliyor.
•   3. kontrolümüz ilk 10 hane toplamının % 10'unun 11. haneye eşit olup olmadığı. Bunu tckimlik değişkenimiz
    hala string olduğu için ve tckimlik[3] gibi kullanımda hanelerine erişebildiğimiz için tek sorunumuz
    bu haneleri sayı olarak kullanıp işlem yaptırabilmek. Onu da -'0' ile yapıyoruz. Yani:

    tckimlik[3]-'0';

    gibi. Böylece 4. indeksteki karakteri rakam halinde kullanabiliyor hale getiriyoruz. Atanması gerekmiyor,
    direkt böyle kullanılabiliyor.
•   4. kontrol ise yine tckimlik-'0' ile sayı olarak haneleri elde etme yönteminin içinde olduğu ve bize
    10. haneyi veren bir algoritma. 1'den 9'a kadar haneleri tek ardışık olarak toplayıp 7 ile çarpıyoruz.
    Sonra bundan 2'den 8'e kadar çift ardışık sayıların toplamını çıkarıyor, sonucun da mod 10'unu alıyoruz.
    Ortaya çıkan sayı bize 10'uncu haneyi veriyor.
•   5. kontrol, ilk Türk vatandaşı olan Mustafa Kemal Atatürk'e verilebilecek TC Kimlik numarası
    10000000146'dan küçük olup olmadığının kontrolüdür. (Aynı zamanda ilk hanenin 0 olmaması da kontrol
    edilmiş olur. Verilebilecek en büyük TC Kimlik No ise 99999999990'dır ancak bundan büyük yazılacak
    herhangi bir sayı 11. hane doğrulamasında veya 11 hane olup olmadığı kontrolünde zaten false döneceğinden
    o sayıdan <= if'i kontrole eklenmedi.
•   Yöntemleri C++ ile "Sıra No Alma Kiosk" projemde kullanmıştım. O dilde yazımı için repositorylerim
    arasından bulunabilir.
 */
namespace _008.TC_Kimlik_Numarası_Çoklu_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen TC Kimlik Numaranızı Girin: ");
            string tckimlik = Console.ReadLine();

            long _tckimlik;
            int onHaneToplam=0;
            int onuncuHaneKontrol = 0;

            // 1. KONTROL: Bütün karakterler sayı mı?
            if (long.TryParse(tckimlik, out _tckimlik) == true)
            {
                // 2. KONTROL: 11 haneli mi?
                if (tckimlik.Length == 11)
                {
                    // 3. KONTROL: 10 hane toplamının 10'a bölümünden kalan = son hane?
                    for (int i = 0; i < tckimlik.Length-1;i++)
                    {
                        // ** Karakteri sayıya -'0' ile dönüştürüyoruz **
                        onHaneToplam += tckimlik[i] - '0'; // Toplama ekliyoruz
                    }

                    int onuncuHane = tckimlik[10] - '0';
                    if (onHaneToplam % 10 == onuncuHane)
                    {
                        // 4. KONTROL: Rakamları hane olarak düşünürsek:
                        // (( 1 + 3 + 5 + 7 + 9 ) * 7 - ( 2 + 4 + 6 + 8 ) ) %10 = 10. hane?
                        for(int i = 0; i <= 8; i += 2)  // 1+3+5+7+9. hanelerin toplamı döngüsü
                        {
                            onuncuHaneKontrol += tckimlik[i]-'0';
                        }
                        onuncuHaneKontrol *= 7; // 7 ile çarpım

                        // 2,4,6 ve 8. hanelerin son çarpımdan tek tek çıkarılma döngüsü
                        for(int i = 1;i <= 7;i += 2)
                        {
                            onuncuHaneKontrol -= tckimlik[i]-'0';
                        }

                        onuncuHaneKontrol = onuncuHaneKontrol % 10; // mod 10 aldığımız satır

                        if (onuncuHaneKontrol == tckimlik[9] - '0')
                        {
                            if(_tckimlik >= 10000000146)
                            {
                                Console.WriteLine("- TC Kimlik Numaranız doğrulandı. -");
                            }
                            else
                            {
                                Console.WriteLine("HATA 5: Oluşturulabilecek aralığın dışında bir sayı girdiniz!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("HATA 4: 10. hane doğrulanmıyor!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("HATA 3: Son hane doğrulanmıyor!");
                    }                    
                }
                else
                {
                    Console.WriteLine("HATA 2: Girilen Tc Kimlik No, 11 haneli değil!");
                }
            }
            else
            {
                Console.WriteLine("HATA 1: Rakam olmayan karakter kullanımı!");
            }

            pause();
        }
        static void pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
