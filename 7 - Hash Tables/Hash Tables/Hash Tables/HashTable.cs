using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    class HashTable
    {
        Node[] buckets;
        int length;

        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node[length];
        }

        public void Display()
        {
            for (int bucket = 0; bucket < buckets.Length; bucket++)
            {
                Node current = buckets[bucket];
                Console.Write(bucket + ": ");
                while (current != null)
                {
                    Console.Write("[" + current.Name + "," + current.Value + "] ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        private int Hash(string str)
        {
            int h = 0;

            foreach (var s in str)
                h = 37 * h + s;

            return h % length;
        }

        public void Insert(string name, int value)
        {
            int bucket = Hash(name);
            buckets[bucket] =
            new Node(name, value, buckets[bucket]);
        }

        public int Search(string name)
        {
            Node current = buckets[Hash(name)];
            while (current != null)
            {
                if (current.Name.Equals(name))
                    return current.Value;

                current = current.Next;
            }
            throw new Exception(name + " Not found.");
        }

        public void Delete(string name)
        {
            int bucket = Hash(name);
            Node current = buckets[bucket];
            Node previous = null;

            while (current != null)
            {
                if (current.Name.Equals(name))
                {
                    if (previous == null)
                    {
                        buckets[bucket] = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                    return;
                }
                previous = current;
                current = current.Next;
            }
            throw new Exception(name + " Not found.");
        }
    }
}
