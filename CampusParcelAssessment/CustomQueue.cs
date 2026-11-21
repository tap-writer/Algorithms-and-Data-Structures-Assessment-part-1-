using System;

namespace CampusParcelAssessment
{
    // Supplied context code. This queue is not assessed.
    public class CustomQueue<T>
    {
        private int maxsize = 10;
        private T[] store;
        private int head = 0;
        private int tail = 0;
        private int numitems = 0;

        public CustomQueue()
        {
            store = new T[maxsize];

        }

        public CustomQueue(int size)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException("size", "Queue size must be positive.");
            maxsize = size;
            store = new T[maxsize];
        }

        public void Enqueue(T value)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full.");
            store[tail] = value;
            tail++;
            if (tail == maxsize) tail = 0;
            numitems++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            T headitem = store[head];
            store[head] = default(T);
            head++;
            if (head == maxsize) head = 0;
            numitems--;
            return headitem;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            return store[head];
        }

        public int Count()
        {
            return numitems;
        }

        public bool IsEmpty()
        {
            return numitems == 0;
        }

        public bool IsFull()
        {
            return numitems == maxsize;
        }

    }
}
