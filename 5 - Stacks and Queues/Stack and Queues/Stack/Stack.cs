using System;
using Single_List;

namespace Stack
{
    class Stack
    {
        private List list;
        public Stack()
        {
            list = new List();
        }
        public void Push(object obj)
        {
            list.InsertFront(obj);
        }
        public object Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack is empty!");
            return list.RemoveFront();
        }
        public bool IsEmpty() { return list.IsEmpty(); }
        public void Display() { list.Display(); }
    }
}
