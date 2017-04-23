using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_121216
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<int> bsTree = new BSTree<int>();

            AVLTree<int> avlTree = new AVLTree<int>();


            avlTree.InsertItem(15);
            avlTree.InsertItem(100);
            avlTree.InsertItem(50);
            avlTree.InsertItem(250);
            avlTree.InsertItem(3);
            avlTree.InsertItem(30);


            string buffer = "Items in Tree: ";
            avlTree.InOrder(ref buffer);

            //Before removeItem
            Console.WriteLine(buffer);
            /*          Console.WriteLine("Max level of the BStree = {0}", bsTree.Height());
                        Console.WriteLine("Number of nodes in the BStree = {0}", bsTree.Count());
                        Console.WriteLine("The item is contained in the BSTree = {0}", bsTree.Contains(9));
                        Console.WriteLine("\n");

                        //After removeItem
                        Console.WriteLine("Item is removed from BS Tree = {0}", bsTree.RemoveItem(2));

                        string buffer2 = "Items in Tree: ";
                        bsTree.InOrder(ref buffer2);

                        Console.WriteLine(buffer2);
                        Console.WriteLine("Max level of the BStree = {0}", bsTree.Height());
                        Console.WriteLine("Number of nodes in the BStree = {0}", bsTree.Count());
                        Console.WriteLine("The item is contained in the BSTree = {0}", bsTree.Contains(10));*/
            Console.ReadLine();



        }
    }
}
