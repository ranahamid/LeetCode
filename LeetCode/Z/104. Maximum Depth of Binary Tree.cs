using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return 1 + Math.Max(left, right);
        }
    }
}
