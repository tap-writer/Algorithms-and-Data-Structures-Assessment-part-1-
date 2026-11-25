using System;
using System.Collections.Generic;

namespace CampusParcelAssessment
{
    // Task A.
    // Hints:
    //Use lecture materials from Week 4B
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation...

    class BinTree<T> where T : IComparable
    {
        protected Node<T> root;

        public BinTree()
        {
            root = null;
        }

        public BinTree(Node<T> node)
        {
            root = node;
        }


        // Recursive traversal functions for Task A.
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if(tree != null)
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
            buffer += tree.Data.ToString() + ",";
            preOrder(tree.Left, ref buffer);
            preOrder(tree.Right, ref buffer);
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            postOrder(tree.Left, ref buffer);
            postOrder(tree.Right, ref buffer);
            buffer += tree.Data.ToString() + ",";
        }

        //Free space, use as necessary to address task requirements... 
    }
}
