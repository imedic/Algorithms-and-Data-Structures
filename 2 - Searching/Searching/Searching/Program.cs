using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        public static int SequentialSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == value)
                    return i;
            return -1;
        }

        public static int BinarySearch(int[] array, params int[] values)
        {
            foreach (var value in values)
            {
                int low = 0;
                int high = array.Length - 1;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    if (value < array[mid])
                        high = mid - 1;
                    else if (value > array[mid])
                        low = mid + 1;
                    else
                        return mid;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            int index = SequentialSearch(array, 6);
            Console.WriteLine("index: " + index);

            index = BinarySearch(array, 6);
            Console.WriteLine("index: " + index);

            index = BinarySearch(array, 6, 0, 7);
            Console.WriteLine("index: " + index);
        }
    }
}
