using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class Node_117
    {
        public int val;
        public Node_117 left;
        public Node_117 right;
        public Node_117 next;

        public Node_117() { }

        public Node_117(int _val)
        {
            val = _val;
        }

        public Node_117(int _val, Node_117 _left, Node_117 _right, Node_117 _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    internal class _117
    {
        public Node_117 Connect(Node_117 root)
        {
            if (root == null)
                return root;
            var queue = new Queue<Node_117>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node_117 Node_117 = queue.Dequeue();
                    if (i < size - 1)
                    {
                        Node_117.next = queue.Peek();
                    }
                    if (Node_117.left != null)
                        queue.Enqueue(Node_117.left);
                    if (Node_117.right != null)
                        queue.Enqueue(Node_117.right);
                }
            }
            return root;
        }
    }
}
