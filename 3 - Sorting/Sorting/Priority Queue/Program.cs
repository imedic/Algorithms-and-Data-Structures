using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap(10);
            try
            {
                for (int i = 0; i < 11; i++)
                    heap.Insert(i);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            heap.Display();
            try
            {
                while (true)
                {
                    int priority = heap.Retrieve();
                    heap.Display();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
