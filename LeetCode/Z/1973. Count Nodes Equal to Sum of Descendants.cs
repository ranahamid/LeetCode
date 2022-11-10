using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1973
    {
        /// <summary>
        /// Runtime: 350 ms, faster than 100.00% of C# online submissions for Count Nodes Equal to Sum of Descendants.
        /// Memory Usage: 78.3 MB, less than 16.67% of C# online submissions for Count Nodes Equal to Sum of Descendants.
        /// </summary>
        int counter = 0;
        public int EqualToDescendants(TreeNode root)
        {
            CountTree(root);
            return counter;
        }
        public int CountTree(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = CountTree(root.left);
            var right = CountTree(root.right);

            if (left + right == root.val)
            {
                counter++;
            }
            return root.val + left + right;
        }
    }
}
