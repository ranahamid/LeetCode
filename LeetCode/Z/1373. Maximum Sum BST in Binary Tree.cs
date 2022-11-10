using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1373
    {
        /// <summary>
        /// Runtime: 220 ms, faster than 86.96% of C# online submissions for Maximum Sum BST in Binary Tree.
        /// Memory Usage: 53.3 MB, less than 78.26% of C# online submissions for Maximum Sum BST in Binary Tree.
        /// </summary>
        public int MaxSum { get; set; } = int.MinValue;
        public int MaxSumBST(TreeNode root)
        {
            DFS(root);
            return MaxSum < 0 ? 0 : MaxSum;
        }
        public NodeInfo DFS(TreeNode root)
        {
            if (root == null)
                return new NodeInfo(sum: 0, isBst: true, minValue: null, maxValue: null);
            var left = DFS(root.left);
            var right = DFS(root.right);
            var isValid = false;
            int sum = root.val + left.Sum + right.Sum;

            if (left.IsBst && right.IsBst && (left.MaxValue == null || root.val > left.MaxValue.val) && (right.MinValue == null || root.val < right.MinValue.val))
            {
                isValid = true;
                MaxSum = Math.Max(MaxSum, sum);
            }
            return new NodeInfo(sum: sum, isBst: isValid, minValue: left.MinValue ?? root, maxValue: right.MaxValue ?? root);
        }
        public class NodeInfo
        {
            public int Sum;
            public bool IsBst;
            public TreeNode MaxValue;
            public TreeNode MinValue;
            public NodeInfo(int sum, bool isBst, TreeNode minValue, TreeNode maxValue)
            {
                Sum = sum;
                IsBst = isBst;
                MinValue = minValue;
                MaxValue = maxValue;
            }
        }
    }
}
