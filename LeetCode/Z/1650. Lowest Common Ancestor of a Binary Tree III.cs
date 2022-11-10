using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class Node_1650
    {
        public int val;
        public Node_1650 left;
        public Node_1650 right;
        public Node_1650 parent;
    }
    internal class _1650
    {
        /// <summary>
        /// Runtime: 97 ms, faster than 96.81% of C# online submissions for Lowest Common Ancestor of a Binary Tree III.
        /// Memory Usage: 43 MB, less than 10.64% of C# online submissions for Lowest Common Ancestor of a Binary Tree III.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public Node_1650 LowestCommonAncestor(Node_1650 p, Node_1650 q)
        {
            var bSet = new HashSet<int>();
            while (p != null)
            {
                //if (bSet.Contains(p.val))
                //    return q;
                bSet.Add(p.val);
                p = p.parent;
            }
            while (q != null)
            {
                if (bSet.Contains(q.val))
                    return q;
                q = q.parent;
            }
            return null;
        }
    }
}
