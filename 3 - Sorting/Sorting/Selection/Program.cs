using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };
            DisplayArrayToConsole(array);

            Selection.Sort(array, 0);
            
            DisplayArrayToConsole(array);
        }

        private static void DisplayArrayToConsole(int[] array)
        {
            Array.ForEach(array, Console.WriteLine);
            Console.WriteLine("---------");
        }
    }
}
