using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_121216
{
    class AVLTree<T> : BSTree<T> where T:IComparable
    {
        public AVLTree()
        {   
            root = null;
        }
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);

            Node<T> pivot = tree.Right;

            tree.Right = pivot.Left;
            pivot.Left = tree;
            tree = pivot;
        }
        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);

            Node<T> pivot = tree.Left;

            tree.Left = pivot.Right;
            pivot.Right = tree;
            tree = pivot;

        }
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
            tree.BalanceFactor = height(ref tree.Left) - height(ref tree.Right);
            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);
        }

    }
}
