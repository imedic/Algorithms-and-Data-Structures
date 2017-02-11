using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Ivo");
            stack.Push("Ana");
            stack.Push("Bob");
            stack.Push("Iva");
            stack.Push("Kim");
            stack.Display();
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    stack.Pop();
                    stack.Display();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            stack.Display();
        }
    }
}
