using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Single_List;

namespace Queue
{
    class Queue
    {
        private List list;
        public Queue()
        {
            list = new List();
        }
        public void Enqueue(object obj)
        {
            list.InsertEnd(obj);
        }
        public object Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue is empty!");
            return list.RemoveFront();
        }
        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }
    }
}
