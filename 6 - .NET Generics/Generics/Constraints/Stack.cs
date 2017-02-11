using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Stack<T> : IEnumerable<T> where T : struct
    {
        int top = -1;
        T[] array;

        public Stack(int capacity)
        {
            array = new T[capacity];
        }

        public void Push(T data)
        {
            if (top == array.Length - 1)
                throw new Exception("Stack is full.");
            array[++top] = data;
        }

        public T Pop()
        {
            if (top == -1)
                throw new Exception("Stack is empty.");
            return array[top--];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= top; i++)
                yield return array[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
