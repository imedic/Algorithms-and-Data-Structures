using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List
{
    class BllList
    {
        private Node head;

        private int count;
        public object Count
        {
            get { return count; }
        }

        public BllList()
        {
            Node dummy = new Node();
            dummy.Next = dummy;
            dummy.Prev = dummy;
            head = dummy;
        }

        public void Append(object r)
        {
            Node node = new Node(r, head, head.Prev);
            node.Prev.Next = head.Prev = node;
            count++;
        }

        public void Remove(object r)
        {
            if (count == 0)
            {
                throw new Exception("List is empty.");
            }

            Node current = Find(r);
            if (current == null)
            {
                throw new Exception("Element is not in the list");
            }
            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
            count--;
        }

        public bool Search(object r)
        {
            return Find(r) != null;
        }

        private Node Find(object r)
        {
            Node current = head.Next;
            while (current != head)
            {
                if (current.Element.Equals(r))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Display()
        {
            Node current = head.Next;
            while (current != head)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        private bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }
    }
}
