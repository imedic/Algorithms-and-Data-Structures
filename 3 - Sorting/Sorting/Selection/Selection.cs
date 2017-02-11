using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Selection
    {
        public static void Sort(int[] array, int startingIndex)
        {
            if (startingIndex == array.Length - 1) return;

            int piccolo = startingIndex;
            for (int i = piccolo + 1; i < array.Length; i++)
            {
                if ((array[i] < array[piccolo]))
                {
                    piccolo = i;

                }
            }

            Swap(ref array[piccolo], ref array[startingIndex]);

            Sort(array, startingIndex + 1);
        }

        private static void Swap(ref int first, ref int second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
    }
}
