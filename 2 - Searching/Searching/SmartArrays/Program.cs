using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartArray smarty = new SmartArray(4);

            for (int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }

            DisplaySmartArrayToConsole(smarty);

            IEnumerator enumerator = smarty.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int current = (int)enumerator.Current;
                Console.Write("{0} ", current);
            }
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Removing " + i);
                smarty.Remove(i);
                DisplaySmartArrayToConsole(smarty);
            }
        }

        private static void DisplaySmartArrayToConsole(SmartArray array)
        {
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
