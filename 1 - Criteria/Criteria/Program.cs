using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1,
                b = 2;

            Console.WriteLine("a = {0}, b = {1}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine("a = {0}, b = {1}", a, b);

            var array = new int[] { 2, 3, 4, 1, 8, 6, 5, 7 };

            DisplayArrayToConsole(array);

            Swap(ref array[2], ref array[3]);

            DisplayArrayToConsole(array);
        }

        private static void DisplayArrayToConsole(int[] array)
        {
            array.ToList().ForEach(Console.WriteLine);
            Console.Write("\n");
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
