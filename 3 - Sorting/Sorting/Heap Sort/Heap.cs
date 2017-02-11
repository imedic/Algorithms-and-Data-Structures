using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Heap
    {
        public static void Sort(int[] array)
        {
            Heapify(array);
            Arrange(array);
        }
        public static void Heapify(int[] array)
        {
            int last = array.Length - 1;
            for (int i = last/2; i >= 0; i--)
            {
                BubbleDown(array, i, last);
            }
        }

        public static void Arrange(int[] array)
        {
            int last = array.Length - 1;
            while (last > 0)
            {
                Swap(array, 0, last--);
                BubbleDown(array, 0, last);
            }
        }

        public static void BubbleDown(
            int[] array,
            int i,
            int last)
        {
            int child = 2 * i + 1;
            if (child < last && array[child] < array[child + 1])
            {
                child++;
            }
            if (child <= last && array[i] < array[child])
            {
                Swap(array, i, child);
                BubbleDown(array, child, last);
            }
        }
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
