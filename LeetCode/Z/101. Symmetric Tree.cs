using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_101
    {
        public int val;
        public TreeNode_101 left;
        public TreeNode_101 right;
        public TreeNode_101(int val = 0, TreeNode_101 left = null, TreeNode_101 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _101
    {
        /// <summary>
        /// Runtime: 136 ms, faster than 59.88% of C# online submissions for Symmetric Tree.
        /// Memory Usage: 39.2 MB, less than 71.23% of C# online submissions for Symmetric Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsSymmetric(TreeNode_101 root)
        {
            return SymmetricTree(root, root);
        }
        public static bool SymmetricTree(TreeNode_101 left, TreeNode_101 right)
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
