using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _572
    {
        /// <summary>
        /// Runtime: 122 ms, faster than 90.01% of C# online submissions for Subtree of Another Tree.
        /// Memory Usage: 46 MB, less than 7.19% of C# online submissions for Subtree of Another Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="subRoot"></param>
        /// <returns></returns>
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
                return false;
            if (root.val == subRoot.val && IsSameTree(root, subRoot))
                return true;
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }
        public bool IsSameTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
                return true;
            if (root == null && subRoot != null || root != null && subRoot == null || root.val != subRoot.val)
                return false;
            return root.val == subRoot.val && IsSameTree(root.left, subRoot.left) && IsSameTree(root.right, subRoot.right);
        }
    }
}
