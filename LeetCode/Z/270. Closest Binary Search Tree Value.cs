using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _270
    {
        /// <summary>
        /// Runtime: 96 ms, faster than 94.03% of C# online submissions for Closest Binary Search Tree Value.
        ///  Memory Usage: 40.8 MB, less than 8.21% of C# online submissions for Closest Binary Search Tree Value.
        /// </summary>
        public double MinValue { get; set; } = int.MaxValue;
        public int Result { get; set; }
        public int ClosestValue(TreeNode root, double target)
        {
            DFS(root, target);
            return Result;
        }
        public void DFS(TreeNode root, double target)
        {
            if (root == null)
                return;
            if (Math.Abs(root.val - target) < MinValue)
            {
                MinValue = Math.Abs(root.val - target);
                Console.WriteLine(MinValue);
                Result = root.val;
            }

            if (root.left != null)
            {
                DFS(root.left, target);
            }
            if (root.right != null)
            {
                DFS(root.right, target);
            }
        }
    }
}
