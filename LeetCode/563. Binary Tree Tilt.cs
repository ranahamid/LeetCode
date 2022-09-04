using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _563
    {
        /// <summary>
        /// Runtime: 144 ms, faster than 62.50% of C# online submissions for Binary Tree Tilt.
        /// Memory Usage: 40.4 MB, less than 36.11% of C# online submissions for Binary Tree Tilt.
        /// </summary>
        public int Count { get; set; }
        public int FindTilt(TreeNode root)
        {
            Count = 0;
            DFS(root);
            return Count;
        }
        public int DFS(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = DFS(root.left);
            var right = DFS(root.right);
            Count += Math.Abs(left - right);
            return root.val + left + right;
        }
    }
}
