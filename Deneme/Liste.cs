using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Liste
    {
        public Node head;

        public Liste()
        {
            head = null;
        }

        public void sonaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = eleman;
                Console.WriteLine("Sona düğüm eklenecekti ancak liste boş olduğundan ilk düğüm olarak eklendi.");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = eleman;
                Console.WriteLine("Sona düğüm eklendi.");
            }
        }

        public void basaEkle(int data)
        {
            Node eleman = new Node(data);

            if (head == null)
            {
                head = eleman;
                Console.WriteLine("Başa düğüm eklenecekti ancak liste boş olduğundan ilk düğüm olarak eklendi");
            }
            else
            {
                eleman.next = head; // eklenen elemanın next'ini head yaptık
                head = eleman;      // head olarak da yeni eklediğimiz elemanı gösterdik
                Console.WriteLine("Listede elemanlar bulunduğundan başa eklenen elemanın next'i head tanımlanıp, head olarak da yeni eleman gösterildi.");
            }

        }

        public void yazdir()
        {
            if (head == null) {
                Console.WriteLine("Liste başlatılmamış.");
            } else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
