using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1325
    {
        /// <summary>
        /// Runtime: 98 ms, faster than 92.98% of C# online submissions for Delete Leaves With a Given Value.
        /// Memory Usage: 40.9 MB, less than 5.26% of C# online submissions for Delete Leaves With a Given Value.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null)
                return null;

            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);

            if (root.left == null && root.right == null && root.val == target)
                return null;

            return root;
        }
    }
}
