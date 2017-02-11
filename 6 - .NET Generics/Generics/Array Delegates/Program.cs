using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = {
                new Player (34, "Balić", 5),
                new Player (5, "Duvnjak", 9),
                new Player (27, "Čupić", 8),
                new Player (9, "Vori", 6),
                new Player (1, "Losert", 7)
            };

            Console.WriteLine(Thread.CurrentThread.CurrentCulture.Name);
            // Thread.CurrentThread.CurrentCulture
                    //= new CultureInfo("es-ES");

            Console.OutputEncoding = Encoding.UTF8;

            Array.Sort(players,
                (a, b) => a.Name.CompareTo(b.Name));

            foreach (var p in players)
                Console.WriteLine(p);
            Console.WriteLine("----------");

            Array.ForEach(players, a => a.Score++);

            foreach (var p in players)
                Console.WriteLine(p);
            Console.WriteLine("----------");

            Player[] array = Array.FindAll(players,
                p => p.Number > 10);

            foreach (var a in array)
                Console.WriteLine(a);
            Console.WriteLine("----------");

            Coach[] coaches = Array.ConvertAll(players,
                p => new Coach(p.Name));

            foreach (var c in coaches)
                Console.WriteLine(c);
            Console.WriteLine("----------");
        }
    }
}
