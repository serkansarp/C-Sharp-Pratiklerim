using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- Struct -
C dilinde sınıf amaçlı kullandığımız structlar kendinden sonraki C++ ve C# dillerindeki sınıflara çok benzer.
Ancak nesnelerini stackte tuttukları için, yani değer tipli oldukları için, büyük veri olursa stack overflow hatası
almaya müsaittir. Bir structtan oluşturulan nesne boyutu 16 byte'ın altındaysa struct, fazlaysa class üzerinden
oluşturulmalıdır. Struct, verileri stackte tuttuğundan daha hızlı ulaşım ve işlem kabiliyeti vardır ancak taşma
sorunu yaşanabilir. O yüzden bu sınır 16 byte olarak belirlenmiştir. Consturctor barındırabilir ama
destructor sınıflara özgüdür. Ayrıca nesne verileri değişikliğe uğrayacaksa yine sınıf tercih edilmelidir. Çünkü
struct, değer tipi olarak tuttuğu için fonksiyonla değiştirilmeye çalışsa da kopyası oluşturulup onun değerini
değiştirir, bizim nesnemiz aynı kalır. Aşağıda örneklendirilmiştir. Detaylara girilmemiştir.
 */

namespace _029.Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Constructor kullanmadan oluşturulan nesne
            Personel p1 = new Personel();
            p1.KurumNo = 1;
            p1.Isim = "Nurten";

            // Constructorla oluşturulan nesne
            Personel p2 = new Personel(2, "Canan");

            Console.WriteLine(p1.KurumNo + ". " + p1.Isim);
            Console.WriteLine(p2.KurumNo + ". " + p2.Isim);

            Console.WriteLine("\n- Şimdi 2. personelimizin ismini fonksiyonla değiştirip fonksiyon içinde yazdırıyoruz. -");
            Degistir(p2);
            Console.WriteLine("\n- Ancak fonksiyonun isim uzayından çıktıktan sonra tekrar çağırdığımızda değişmediğini görüyoruz. -");
            Console.WriteLine(p2.KurumNo + ". " + p2.Isim);
            


            Console.ReadKey();
        }

        static void Degistir(Personel a)
        {
            a.KurumNo = 8;
            a.Isim = "Dilek";
            Console.WriteLine("Fonksiyonla değiştirilmiş nesne: "+a.KurumNo+". "+a.Isim);
        }

    }

    struct Personel
    {
        public int KurumNo;
        public string Isim;

        public Personel(int x, string y)    // Default constructorla çalışmaz, değer bekler
        {
            KurumNo = x;
            Isim = y;
        }


    }
}
