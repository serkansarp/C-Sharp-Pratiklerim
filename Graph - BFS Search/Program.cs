using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Graph___BFS_Search
{  
 /* 
         1
       / | \
      2  5  9
     /  /  \  \
    3  6    8  10
   /  /
  4  7

- Belirli bir kaynak tepe noktasından BFS geçişini yazdıran C# programı
*/


    class Graph
    {
        // Düğüm Sayısı
        private int _V;

        // Komşu Düğüm Listesi
        LinkedList<int>[] komsu;

        // Kurucu
        public Graph(int V)
        {
            komsu = new LinkedList<int>[V];
            for(int i = 0; i < komsu.Length; i++)
                komsu[i] = new LinkedList<int>();
            
            _V= V;
        }

        // Kenar Ekleme Metodu
        public void KenarEkle(int v, int w)
        {
            komsu[v].AddLast(w);
        }

        // Belirli bir kaynaktan BFS geçişini yazdıran metod
        public void BFS(int s)
        {
            // Tüm düğümler ziyaret edilmedi olarak işaretlenmektedir
            // (C#’da Varsayılan olarak false ayarlanmıştır)
            bool[] ziyaret = new bool[_V];
            for (int i = 0; i < _V; i++)
                ziyaret[i] = false;

            // BFS için bir kuyruk oluşturulması
            LinkedList<int> kuyruk = new LinkedList<int>();

            // Geçerli düğüm Ziyaret edildi olarak işaretlenerek kuyruğa eklenmektedir
            ziyaret[s] = true;
            kuyruk.AddLast(s);

            while (kuyruk.Any())
            {
                // Kuyruktan bir tepe noktasının çıkartılması ve yazdırılması
                s = kuyruk.First();
                Console.Write(s + " ");
                kuyruk.RemoveFirst();
            
                // Kuyruktan çıkarılan tepe noktalarının tüm bitişik düğümleri alınmaktadır
                // Bitişik ziyaret edilmemişse, ziyaret edildi olarak işaretlenmekte ve kuyruğa alınmaktadır
                LinkedList<int> list = komsu[s];
                foreach (var val in list)
                {
                    if (!ziyaret[val])
                    {
                        ziyaret[val] = true;
                        kuyruk.AddLast(val);
                    }
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Graph g = new Graph(11);
            g.KenarEkle(1, 2);
            g.KenarEkle(2, 3);
            g.KenarEkle(3, 4);
            g.KenarEkle(1, 5);
            g.KenarEkle(5, 6);
            g.KenarEkle(6, 7);
            g.KenarEkle(5, 8);
            g.KenarEkle(1, 9);
            g.KenarEkle(9, 10);
            Console.Write("Breadth First Search Algoritması(1. düğümden başlamaktadır)\n");
            g.BFS(1);


            Console.ReadKey();

        }
    }
}
