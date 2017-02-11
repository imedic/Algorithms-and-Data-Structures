using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
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
                new Student ("Joe", 4.7),
                new Student ("Tom", 4.4),
                new Student ("Iko", 4.6),
            };

            DisplayArrayToConsole(students);

            Quick.Partition(students, 0, students.Length - 1, Student.CompareName);
            DisplayArrayToConsole(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareName);
            DisplayArrayToConsole(students);

            Quick.Sort(students, 0, students.Length - 1, Student.CompareGrade);
            DisplayArrayToConsole(students);
        }

        private static void DisplayArrayToConsole(object[] array)
        {
            Array.ForEach(array, Console.WriteLine);
            Console.WriteLine("-----------");
        }
    }
}
