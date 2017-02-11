using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
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

            DisplayArrayToConsole(students);

            StudentComparer comparer = new StudentComparer(StudentComparerType.Name);
            Bubble.Sort(students, comparer);
            DisplayArrayToConsole(students);

            comparer = new StudentComparer(StudentComparerType.Grade);
            Bubble.Sort(students, comparer);
            DisplayArrayToConsole(students);

        }

        private static void DisplayArrayToConsole(object[] array)
        {
            array.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("---------------");   
        }
    }
}
