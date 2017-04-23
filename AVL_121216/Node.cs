using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_121216
{
    class Node<T> where T : IComparable {

        private T data;
        public Node<T> Left;
        public Node<T> Right;
        private int balanceFactor = 0; //added for AVLTree


        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            set { data = value; }
            get { return data; }
        }

        public int BalanceFactor
        {
            set { balanceFactor = value; }
            get { return balanceFactor; }
        }

    }
}
