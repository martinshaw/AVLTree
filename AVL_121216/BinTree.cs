using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_121216
{
    class BinTree<T> where T : IComparable {

        protected Node<T> root;

        public BinTree()  //creates an empty tree
        {
            root = null;
        }

        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            /*
              if tree is not empty InOrder traverse left sub-tree display value in node InOrder 
              traverse right sub-tree
              end if
             */
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }

        }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            /*
                if tree is not empty display value in node Preorder traverse left sub - tree 
                pre - order traverse right sub - tree
                end if
            */
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preOrder(tree.Left, ref buffer);
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            /*
                 if tree is not empty
                 post-order traverse left sub-tree
                 post-order traverse right sub-tree
                 display value in node
                 end if
             */

            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }

    }
}
