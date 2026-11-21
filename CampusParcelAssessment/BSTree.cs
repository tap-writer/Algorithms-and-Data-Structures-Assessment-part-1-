using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusParcelAssessment
{
    // Task A.
    // Hints:
    //Use lecture materials from Week 5
    // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation.

    class BSTree<T> : BinTree<T> where T : IComparable
    {

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
            else if (item.CompareTo(tree.Data)<0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data)>0)   
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
        {
            throw new NotImplementedException();
        }


        public int Count()
        {
            throw new NotImplementedException();
        }

        //Free space, use as necessary to address task requirements... 





    }// End of class
}
