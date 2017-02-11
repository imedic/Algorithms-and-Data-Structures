using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable table = new HashTable(9);
            table.Insert("Ivo", 5);
            table.Insert("Ana", 1);
            table.Insert("Joe", 7);
            table.Insert("Bob", 4);
            table.Insert("Kim", 3);
            table.Insert("Ena", 8);
            table.Insert("Iva", 2);
            table.Insert("Tea", 9);
            table.Insert("Lea", 6);

            table.Display();

            string name = "Bob";

            try
            {
                int value = table.Search(name);
                Console.WriteLine(name + ", " + value);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            try
            {
                table.Delete(name);
                table.Delete("Joe");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            table.Display();
        }
    }
}
