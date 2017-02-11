using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> integers = new Stack<int>(10);
            //Stack<string> strings = new Stack<string>(10);
            Stack<Point> points = new Stack<Point>(5);

            Point a = new Point(1, 1);
            points.Push(a);
            points.Push(new Point(2, 2));
            points.Push(new Point(3, 3));

            foreach (var p in points) Console.WriteLine(p);

            points.Pop();
            points.Pop();
            points.Pop();

            Queue<string> strings = new Queue<string>(5);
            //Queue<int> integers = new Queue<int>(5);

            strings.Enqueue("Ivo");
            strings.Enqueue("Ana");
            strings.Enqueue("Bob");
            strings.Enqueue("Kim");
            strings.Enqueue("Lia");

            foreach (var s in strings) Console.WriteLine(s);

            Console.WriteLine("----------");

            strings.Dequeue();
            strings.Dequeue();

            foreach (var s in strings) Console.WriteLine(s);
        }
    }
}
