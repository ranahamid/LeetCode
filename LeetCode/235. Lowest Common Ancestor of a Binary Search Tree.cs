using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_235
    {
        public int val;
        public TreeNode_235 left;
        public TreeNode_235 right;
        public TreeNode_235(int val = 0, TreeNode_235 left = null, TreeNode_235 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

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
        public TreeNode_235 LowestCommonAncestor(TreeNode_235 root, TreeNode_235 p, TreeNode_235 q)
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
