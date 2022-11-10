using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _814
    {
        /// <summary>
        /// Runtime: 70 ms, faster than 100.00% of C# online submissions for Binary Tree Pruning.
        /// Memory Usage: 38.2 MB, less than 5.13% of C# online submissions for Binary Tree Pruning.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
                return null;
            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if (root.val == 0 && root.left == null && root.right == null)
                return null;
            return root;
        }
    }
}
