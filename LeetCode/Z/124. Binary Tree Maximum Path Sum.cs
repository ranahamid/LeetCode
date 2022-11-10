using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _124
    {
        /// <summary>
        /// Runtime: 97 ms, faster than 98.29% of C# online submissions for Binary Tree Maximum Path Sum.
        /// Memory Usage: 44.8 MB, less than 7.00% of C# online submissions for Binary Tree Maximum Path Sum.
        /// </summary>
        int maxSum = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            FindMaxPathSum(root);
            return maxSum;
        }
        public int FindMaxPathSum(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = Math.Max(FindMaxPathSum(root.left), 0);
            var right = Math.Max(FindMaxPathSum(root.right), 0);
            var currentSum = root.val + left + right;
            maxSum = Math.Max(currentSum, maxSum);
            return root.val + Math.Max(left, right);
        }
    }
}
