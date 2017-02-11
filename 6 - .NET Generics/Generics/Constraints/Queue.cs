using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Queue<T> : IEnumerable<T> where T : class
    {
        private T[] array;
        private int to;
        private int from;
        private int occupied;

        public Queue(int capacity)
        {
            array = new T[capacity];
        }

        public void Enqueue(T data)
        {
            if (occupied == array.Length)
                throw new Exception("Queue is full.");
            array[to] = data;
            to = (to + 1) % array.Length;
            occupied++;
        }

        public T Dequeue()
        {
            if (occupied == 0)
                throw new Exception("Queue is emplty.");

            T data = array[from];
            from = (from + 1) % array.Length;
            occupied--;
            return data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = from; i <= occupied; i++)
                yield return array[(i) % array.Length];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
