using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Node
    {
        public int Data { get; set; }
        // public Node Left { get; set; }
        // public Node Right { get; set; }
        // Properties can not be passed by ref
        public Node left;
        public Node right;

        public Node(int data)
        {
            Data = data;
            left = right = null;
        }

        public void Insert(int value)
        {
            if (value < Data)
            {
                if (left == null)
                    left = new Node(value);
                else
                    left.Insert(value);
            }
            else
            {
                if (right == null)
                    right = new Node(value);
                else
                    right.Insert(value);
            }
        }
    }
}
