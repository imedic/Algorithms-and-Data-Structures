using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public enum TraversalType { PreOrder, InOrdered, PostOrder }

    class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            if (root == null)
                root = new Node(value);
            else
                root.Insert(value);
        }

        public bool Search(int value)
        {
            Node node = Search(root, value);
            return node != null;
        }

        private Node Search(Node current, int value)
        {
            if (current == null)
                return null;

            int cmp = current.Data.CompareTo(value);
            if (value == current.Data)
                return current;
            if (value < current.Data)
                return Search(current.left, value);


            return Search(current.right, value);
        }

        public void Delete(int value)
        {
            Delete(ref root, value);
        }

        private void Delete(ref Node current, int value)
        {
            if (current == null) return;
            if (value < current.Data)
            {
                Delete(ref current.left, value);
            }
            else if (value > current.Data)
            {
                Delete(ref current.right, value);
            }
            else
            {
                if (current.right == null)
                {
                    current = current.left;
                }
                else if (current.left == null)
                {
                    current = current.right;
                }
                else
                {
                    current.Data = DeleteSuccessor(ref current.right);
                }
            }
        }

        private int DeleteSuccessor(ref Node current)
        {
            int successor;
            if (current.left == null)
            {
                successor = current.Data;
                current = current.right;
                return successor;
            }
            return DeleteSuccessor(ref current.left);
        }

        public void Traverse(TraversalType traverse)
        {
            switch (traverse)
            {
                case TraversalType.PreOrder:
                    TraversePreorder(root);
                    break;
                case TraversalType.InOrdered:
                    TraverseInorder(root);
                    break;
                case TraversalType.PostOrder:
                    TraversePostorder(root);
                    break;
                default:
                    Console.WriteLine("What a #@$@#@!");
                    break;
            }
        }
        private void TraversePreorder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Data + " ");
                TraversePreorder(node.left);
                TraversePreorder(node.right);
            }
        }
        private void TraverseInorder(Node node)
        {
            if (node != null)
            {
                TraverseInorder(node.left);
                Console.WriteLine(node.Data + " ");
                TraverseInorder(node.right);
            }
        }
        private void TraversePostorder(Node node)
        {
            if (node != null)
            {
                TraversePostorder(node.left);
                TraversePostorder(node.right);
                Console.WriteLine(node.Data + " ");
            }
        }
    }
}
