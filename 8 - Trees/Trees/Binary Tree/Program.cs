using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            int[] array = { 4, 2, 6, 7, 1, 3, 5, 8 };

            foreach (int i in array) tree.Insert(i);

            tree.Traverse(TraversalType.InOrdered);

            int value = 4;
            if (tree.Search(value))
                Console.WriteLine("Value {0:d} is found in the tree.", value);
            else
                Console.WriteLine("Value {0:d} is not found in the tree.", value);

            tree.Delete(4);
            tree.Traverse(TraversalType.InOrdered);
        }
    }
}
