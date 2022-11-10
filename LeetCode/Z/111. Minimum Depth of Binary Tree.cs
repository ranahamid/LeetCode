using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class Node_111
    {
        public int val;
        public Node_111 left;
        public Node_111 right;
        public Node_111(int val = 0, Node_111 left = null, Node_111 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _111
    {

        public int MinDepth(Node_111 root)
        {

            if (root == null)
                return 0;
            Queue<Node_111> queue = new Queue<Node_111>();
            queue.Enqueue(root);
            var counter = 0;
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                counter++;
                while (count < queueLen)
                {
                    Node_111 node = queue.Dequeue();
                    if (node.left == null && node.right == null)
                    {
                        return counter;
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    count++;

                }
            }
            return counter;
        }


    }
}
