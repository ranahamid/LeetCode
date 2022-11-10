using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _429
    {
        public class Node_429
        {
            public int val;
            public IList<Node_429> children;

            public Node_429() { }

            public Node_429(int _val)
            {
                val = _val;
            }

            public Node_429(int _val, IList<Node_429> _children)
            {
                val = _val;
                children = _children;
            }
        }
        public static IList<IList<int>> LevelOrder(Node_429 root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<Node_429> queue = new Queue<Node_429>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var currentVal = new List<int>();
                while (count < queueLen)
                {
                    Node_429 node = queue.Dequeue();
                    currentVal.Add(node.val);
                    foreach (var item in node.children)
                    {
                        queue.Enqueue(item);
                    }
                    count++;
                }

                result.Add(currentVal);
            }
            return result;
        }

    }
}
