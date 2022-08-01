using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _235
    {
        /// <summary>
        /// Runtime: 166 ms, faster than 40.05% of C# online submissions for Lowest Common Ancestor of a Binary Search Tree.
        /// Memory Usage: 41.9 MB, less than 52.10% of C# online submissions for Lowest Common Ancestor of a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val > p.val && root.val > q.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if (root.val < p.val && root.val < q.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }
}
