using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class Node_510
    {
        public int val;
        public Node_510 left;
        public Node_510 right;
        public Node_510 parent;
    }
    internal class _510
    {
        /// <summary>
        /// Runtime: 152 ms, faster than 58.59% of C# online submissions for Inorder Successor in BST II.
        /// Memory Usage: 41.6 MB, less than 76.56% of C# online submissions for Inorder Successor in BST II.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Node_510 InorderSuccessor(Node_510 x)
        {
            if (x.right != null)
            {
                x = x.right;
                while (x.left != null)
                {
                    x = x.left;
                }
                return x;
            }
            while (x.parent != null && x.parent.right == x)
            {
                x = x.parent;
            }
            return x.parent;
        }
    }
}
