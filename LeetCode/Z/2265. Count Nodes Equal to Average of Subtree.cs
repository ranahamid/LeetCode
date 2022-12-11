using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2265
    {
        /// <summary>
        /// Runtime 118 ms Beats 80% Memory 39.5 MB Beats 31.43%
        /// </summary>
        int counter = 0;
        public int AverageOfSubtree(TreeNode root)
        {
            dfs(root);
            return counter;
        }
        public int[] dfs(TreeNode root)
        {
            if (root == null)
                return new int[] { 0, 0 };

            var left = dfs(root.left);
            var right = dfs(root.right);

            var currentSum = left[0] + right[0] + root.val;
            var count = left[1] + right[1] + 1;
            var avg = currentSum / count;
            if (avg == root.val)
                counter++;
            return new int[] { currentSum, count };
        }
    }
}
