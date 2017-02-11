using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static bool Compare<T>(T a, T b)
        {
            // if (a == b)
            // if (a > b)
            // if (a < b)
            if (a.Equals(b)) return true;
            // b = null;
            b = default(T);
            return false;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2;
            string s1 = "Ivo", s2 = "Ana";

            Swap<int>(ref a, ref b);
            Console.WriteLine("a= " + a + "b= " + b);
            Swap(ref s1, ref s2);
            Console.WriteLine("s1= " + s1 + " s2= " + s2);

            bool cmp = Compare<int>(a, 2);
            Console.WriteLine(cmp);
            cmp = Compare(s1, s2);
            Console.WriteLine(cmp);

            ArrayList ordinary = new ArrayList();
            ordinary.Add(1);
            ordinary.Add(2);
            ordinary.Add("Tom");

            int i = (int)ordinary[0];
            ordinary.Add("Iva");

            foreach (var x in ordinary)
                Console.WriteLine(x);

            List<int> generic = new List<int>();
            generic.Add(1);
            generic.Add(2);

            //list.Add("Ana");

            foreach (var x in generic)
                Console.WriteLine(x);
        }
    }
}
