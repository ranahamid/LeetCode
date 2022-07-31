using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _101
    {
        /// <summary>
        /// Runtime: 136 ms, faster than 59.88% of C# online submissions for Symmetric Tree.
        /// Memory Usage: 39.2 MB, less than 71.23% of C# online submissions for Symmetric Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode root)
        {
            return SymmetricTree(root, root);
        }
        public static bool SymmetricTree(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left == null || right == null)
                return false;
            var result = left.val == right.val &&
                       SymmetricTree(left.left, right.right) &&
                        SymmetricTree(left.right, right.left);
            return result;
        }
    }
}
