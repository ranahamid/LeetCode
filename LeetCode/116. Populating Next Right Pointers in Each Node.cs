using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode
{
    public class Node_116
    {
        public int val;
        public Node_116 left;
        public Node_116 right;
        public Node_116 next;

        public Node_116() { }

        public Node_116(int _val)
        {
            val = _val;
        }

        public Node_116(int _val, Node_116 _left, Node_116 _right, Node_116 _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    internal class _116
    {
        /// <summary>
        /// Runtime: 83 ms, faster than 99.76% of C# online submissions for Populating Next Right Pointers in Each Node_116.
        /// Memory Usage: 43.1 MB, less than 12.44% of C# online submissions for Populating Next Right Pointers in Each Node_116.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Node_116 Connect(Node_116 root)
        {
            if (root == null)
                return root;
            var queue = new Queue<Node_116>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    Node_116 Node_116 = queue.Dequeue();
                    if (i < size - 1)
                    {
                        Node_116.next = queue.Peek();
                    }
                    if (Node_116.left != null)
                        queue.Enqueue(Node_116.left);
                    if (Node_116.right != null)
                        queue.Enqueue(Node_116.right);
                }
            }
            return root;
        }
    }
}
