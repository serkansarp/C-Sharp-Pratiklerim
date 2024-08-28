using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph___DFS_Search
{
    /*
             1
           / | \
          2  5  9
         /  / \  \
        3  6   8  10
       /  /
      4  7

    */

    // Üstte görseli verilen grafın DFS geçiş sınıfı. Yönlendirilmiş bir grafı temsil ediyor
    class Graph
    {
        private int V;  // Düğüm sayısı

        // Komşu düğümlerin tutulduğu liste
        private List<int>[] adj;

        // Kurucu
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
                adj[i] = new List<int>();
        }

        // Kenar ekleme metodu
        public void KenarEkle(int v, int w)
        {
            adj[v].Add(w);  // v listesine w eklenmesi
        }

        // DFS metodunun kullanılacağı yardımcı metod
        public void DFSYardimci(int v, bool[] ziyaret)
        {
            // Bir düğümü 'ziyaret edildi' olarak işaretleyip yazdırma
            ziyaret[v] = true;
            Console.Write(v + " ");

            // Bu düğüme bitişik tüm düğümler için tekrarla
            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!ziyaret[n])
                    DFSYardimci(n, ziyaret);

            }

        }

        // DFS geçişini yapan metod
        // Özyinelemeli olarak DFSYardimci() kullanmaktadır
        public void DFS(int v)
        {
            // Tüm düğümleri 'Ziyaret edilmedi' olarak işaretle (C# varsayılanı false'tur)
            bool[] ziyaret = new bool[V];

            // DFS geçmişinin çağırılması için özyinelemeli DFSYardimci
            DFSYardimci(v, ziyaret);
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

            Console.WriteLine("Önce derinlik geçişi - Başlangıç 5");

            // Geçiş fonksiyonunun çağırılması
            g.DFS(5);



            Console.ReadKey();




        }
    }
}
