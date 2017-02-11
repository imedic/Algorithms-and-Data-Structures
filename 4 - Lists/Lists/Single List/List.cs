using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    class List
    {
        private Node head;
        private Node tail;

        public List() { head = tail = null; }

        public bool IsEmpty() { return head == null; }

        public void InsertFront(object data)
        {
            if (IsEmpty())
            {
                head = tail = new Node(data, null);
            }
            else
            {
                head = new Node(data, head);
            }
        }

        public void InsertEnd(object data)
        {
            if (IsEmpty())
            {
                head = tail = new Node(data, null);
            }
            else
            {
                tail = tail.Next = new Node(data, null);
            }
        }

        public object RemoveFront()
        {
            object obj = null;
            if (IsEmpty())
            {
                throw new Exception("List is empty!");
            }

            obj = head.Element;
            if (head.Equals(tail))
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
            }

            return obj;
        }

        public object RemoveEnd()
        {
            object obj = null;
            if (IsEmpty())
            {
                throw new Exception("List is empty!");
            }

            obj = tail.Element;
            if (head.Equals(tail)) head = tail = null;
            else
            {
                Node current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                tail = current;
                current.Next = null;
            }
            return obj;
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
