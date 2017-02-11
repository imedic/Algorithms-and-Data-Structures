using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Factorial(6);
            Console.WriteLine("6!= " + result);

            result = Fibonacci(6);
            Console.WriteLine("Fibonacci od 6 with recursion = {0}", result);

            result = FibonacciIter(6);
            Console.WriteLine("Fibonacci od 6 with interation = {0}", result);
        }

        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciIter(int n)
        {
            var fibonacci = new int[n + 1];

            if (n <= 0) return 0;

            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            return fibonacci[n];
        }
    }
}
