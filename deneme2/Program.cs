using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree();

            bst.root = bst.insert(bst.root, 10);
            bst.root = bst.insert(bst.root, 5);
            bst.root = bst.insert(bst.root, 15);
            bst.root = bst.insert(bst.root, 20);
            bst.root = bst.insert(bst.root, 4);
            bst.root = bst.insert(bst.root, 8);
            bst.root = bst.insert(bst.root, 12);

            bst.inOrder(bst.root);

            bst.root = bst.delete(bst.root, 4);
            bst.root = bst.delete(bst.root, 20);
            bst.root = bst.delete(bst.root, 10);

            Console.WriteLine();
            bst.inOrder(bst.root);
            
            Console.ReadKey();
        }
    }

    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

        public Node newNode(int x)
        {
            root = new Node(x);
            return root;
        }

        public Node insert(Node root, int data)
        {
            if (root != null)
            {
                if (data < root.data)
                    root.left = insert(root.left, data);
                else
                    root.right = insert(root.right, data);
            }
            else
                root = new Node(data);

            return root;
        }

        public void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
        }

        public Node delete(Node root, int x)
        {
            Node t1, t2;    // Geçici olarak kullanmak için oluşturduğumuz global değişken nodelar

            if (root == null)
                return null;

            if (root.data == x)
            {
                if (root.left == root.right) // İkisi de nulldır, silinecek düğümün altı boştur.
                {
                    root = null;
                    return null;
                }
                else if (root.left == null) // Sol çocuğu yok
                {
                    t1 = root.right; 
                    return t1;
                }
                else if (root.right == null) // Sağ çocuğu yok
                {
                    t1 = root.left;
                    return t1;
                }
                else // Altındaki iki çocuğu da mevcut
                {
                    t1 = t2 = root.right;
                    while (t1.left != null)
                    {
                        t1=t1.left;
                    }
                    t1.left = root.left;

                    return t2;
                }

            }
            else
            {
                if (x < root.data)
                {
                    root.left = delete(root.left, x);
                }
                else
                {
                    root.right = delete(root.right, x);
                }
                return root;

            }
            
        }


    }



}
