using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5 , 4, 8};

            DisplayArrayToConsole(array);

            Heap.Sort(array);
            DisplayArrayToConsole(array);
        }

        private static void DisplayArrayToConsole(int[] array)
        {
            array.ToList().ForEach(s => Console.Write("{0} ", s));
            Console.WriteLine();
        }
    }
}
