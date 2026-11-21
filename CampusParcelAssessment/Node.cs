using System;

namespace CampusParcelAssessment
{
    public class Node<T> where T : IComparable
    {
        // Task A.
        // Hints:
        //Use lecture materials from Week 4B
        // and lab sheet 'Lab 5: BinTree and BSTree' to aid with implementation.
        // Add if you need

        private T data;
        public Node<T> Left, Right;

        public Node(T item)
        {
            Data = item;
            Left = null;
            Right = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

    } 
}
