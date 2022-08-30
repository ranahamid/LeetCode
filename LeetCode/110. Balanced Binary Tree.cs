using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _110
    {
        /// <summary>
        /// Runtime: 111 ms, faster than 90.25% of C# online submissions for Balanced Binary Tree.
        /// Memory Usage: 43.2 MB, less than 8.44% of C# online submissions for Balanced Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Height(TreeNode root)
        {
            if (root == null)
                return -1;
            else
                return 1 + Math.Max(Height(root.left), Height(root.right));
        }
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            if (Math.Abs(Height(root.left) - Height(root.right)) < 2 &&
                IsBalanced(root.left) && IsBalanced(root.right))
                return true;
            return false;
        }
    }
}
