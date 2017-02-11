using System;
using System.Collections;

namespace SmartArrays
{
    class SmartArray
    {
        int size;
        int last = -1;
        int[] array;

        public SmartArray(int size)
        {
            this.array = new int[size];
            this.size = array.Length;
        }

        public int Length
        {
            get { return last + 1; }
        }

        public void Add(int item)
        {
            if (last == (size - 1))
            {
                Array resized = Array.CreateInstance(typeof(int), size * 2);
                Array.Copy(array, resized, size);
                array = (int[])resized;
                size = array.Length;
            }
            array[++last] = item;
        }

        public void Remove(int item)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (array[i] == item)
                {
                    Array.Copy(array, i + 1, array, i, last - i);
                    last--;
                    break;
                }
            }
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            return new SmartEnumerator(this);
        }

        private class SmartEnumerator : IEnumerator, IDisposable
        {
            int index = -1;
            SmartArray smarty;
            public SmartEnumerator(SmartArray smarty)
            {
                this.smarty = smarty;
            }

            public bool MoveNext()
            {
                index++;
                return index < smarty.Length;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }

            public object Current
            {
                get { return smarty.array[index]; }
            }

            public void Dispose() { }
        }
    }
}
