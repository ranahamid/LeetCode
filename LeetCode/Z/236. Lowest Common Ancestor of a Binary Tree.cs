using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _236
    {
        /// <summary>
        /// Runtime: 101 ms, faster than 93.06% of C# online submissions for Lowest Common Ancestor of a Binary Tree.
        /// Memory Usage: 41.2 MB, less than 46.32% of C# online submissions for Lowest Common Ancestor of a Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left == null)
                return right;
            if (right == null)
                return left;
            return root;
        }
    }
}
