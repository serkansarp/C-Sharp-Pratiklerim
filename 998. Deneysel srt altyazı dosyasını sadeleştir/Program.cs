using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _998.Deneysel_srt_altyazı_dosyasını_sadeleştir
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a random path (not a file) and assign to a variable  
            string path = @"C:\Users\Public\Documents\";

            // içerisindeki bütün srt dosyalarını liste içerisine ekle
            string[] files = System.IO.Directory.GetFiles(path, "*.srt");

            // bir fonksiyon istiyorum, srt dosyasını parametre alıp içerisindeki < > karakterleri ve arasında kalanlar ile ve { } karakterleri ile arasında kalanları silsin.
            // ve aynı dosyanın üzerine yazsın.
            // örnek: <font color="#E5E5E5">Merhaba</font> -> Merhaba
            // örnek: {y:i}Merhaba{y:i} -> Merhaba
            // örnek: <font color="#E5E5E5">Merhaba{y:i}Dünya</font> -> MerhabaDünya
            // evet şimdi bu fonksiyonu yazar mısınız?
            // ve bu fonksiyonu bütün srt dosyaları için çalıştırın.
            // ve sonucu ekrana yazdırın.
            // ve sonucu aynı dosyanın üzerine yazdırın.
            foreach (string file in files) {
                string text = System.IO.File.ReadAllText(file);
                text = text.Replace("<font color=\"#E5E5E5\">", "").Replace("</font>", "").Replace("{y:i}", "");
                System.IO.File.WriteAllText(file, text);
                Console.WriteLine(text);












            }
    }
}
