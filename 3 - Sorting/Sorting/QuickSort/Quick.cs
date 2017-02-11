using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    delegate bool Comparison(object a, object b);

    class Quick
    {
        public static void Sort(
            object[] array,
            int left,
            int right,
            Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }

        public static int Partition(
            object[] array,
            int left,
            int right,
            Comparison cmp)
        {
            object pivot = array[left];
            int last = left;
            for (int i = last + 1; i <= right; i++)
            {
                if (cmp(array[i], pivot))
                {
                    Swap(array, ++last, i);
                }
            }

            Swap(array, left, last);
            return last;
        }

        static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
