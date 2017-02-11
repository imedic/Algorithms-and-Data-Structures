using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student ("Ivo", 4.1),
                new Student ("Ana", 4.9),
                new Student ("Iva", 4.3),
                new Student ("Bob", 4.5),
                new Student ("Joe", 4.7)
            };

            students.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("\n---------------- \n");

            Bubble.Sort(students);

            Array.ForEach(students, Console.WriteLine);
        }
    }
}
