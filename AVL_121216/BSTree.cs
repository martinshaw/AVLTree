using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_121216
{
    class BSTree<T> : BinTree<T> where T : IComparable { 

        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        {
            return height(ref root);
        }

        protected int height(ref Node<T> tree)
        //Return the max level of the tree
        {
            if (tree == null)
            {
                return 0;
            }

            int leftHeight = height(ref tree.Left);
            int rightHeight = height(ref tree.Right);

            if (leftHeight > rightHeight)
            {
                return leftHeight + 1;
            }
            else
            {
                return rightHeight + 1;
            }
        }

        public int Count()
        {
            return count(ref root);
        }

        private int count(ref Node<T> tree)
        //Return the number of nodes in the tree
        {
            int counter = 0;

            if (tree == null)
            {
                return 0;
            }
            else if (tree.Left != null)
            {
                counter += count(ref tree.Left);
                counter++;
            }
            else if (tree.Right != null)
            {
                counter += count(ref tree.Right);
                counter++;
            }
            return counter;
        }


        public Boolean Contains(T item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(T item, ref Node<T> tree)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            if (tree == null)
            {
                return false;
            }

            else if (tree.Data.CompareTo(item) == 0)
            {
                return true;
            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                return contains(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)

            {
                return contains(item, ref tree.Right);
            }
            else return false;
        }

        public Boolean RemoveItem(T item)
        {
            return removeItem(item, ref root);
        }

        private Boolean removeItem(T item, ref Node<T> tree)
        {
            //Case 1
            if (tree == null)
            {
                Console.WriteLine("Tree empty");
                return false;
            }
            //Find the item
            else if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                removeItem(item, ref tree.Right);
            }
            //Case 2
            else if (tree.Left == null)
            {
                tree = tree.Right;
                return true;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
                return true;
            }
            //Case 3
            else
            {
                T newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
                return true;
            }

            return false;
        }
        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null) //Stopping condition
            {
                return tree.Data;
            }
            return leastItem(tree.Left);
        }

    }
}
