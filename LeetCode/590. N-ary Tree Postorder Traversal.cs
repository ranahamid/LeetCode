using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Node_590
    {
        public int val;
        public IList<Node_590> children;

        public Node_590() { }

        public Node_590(int _val)
        {
            val = _val;
        }

        public Node_590(int _val, IList<Node_590> _children)
        {
            val = _val;
            children = _children;
        }
    }
    internal class _590
    {
        /// <summary>
        /// Runtime: 292 ms, faster than 29.03% of C# online submissions for N-ary Tree Level Order Traversal.
        /// Memory Usage: 45.5 MB, less than 47.18% of C# online submissions for N-ary Tree Level Order Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Postorder(Node_590 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            return result;
        }

        public static List<int> Traverse(Node_590 current, List<int> result)
        {

            foreach (var child in current.children)
            {
                Traverse(child, result);
            }
            result.Add(current.val);
            return result;
        }
    }
}
