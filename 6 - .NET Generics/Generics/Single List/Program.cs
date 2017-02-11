using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> a = new Node<int>(5);

            GenericList<int> integers = new GenericList<int>();

            integers.AddFront(1);
            integers.AddFront(2);
            integers.AddFront(3);

            // integers.AddFront("Bob");

            foreach (int i in integers)
                Console.WriteLine(i);

            Console.WriteLine("---------------");

            GenericList<string> strings =
                new GenericList<string>();
                
            strings.AddFront("Ana");
            strings.AddFront("Iva");
            strings.AddFront("Iva");

            // strings.AddFront(5);
            // integers = strings;

            foreach (string s in strings)
                Console.WriteLine(s);
        }
    }
}
