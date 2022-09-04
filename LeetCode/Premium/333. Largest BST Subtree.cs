using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _333
    {
        /// <summary>
        /// Runtime: 105 ms, faster than 71.88% of C# online submissions for Largest BST Subtree.
       /// Memory Usage: 40.6 MB, less than 12.50% of C# online submissions for Largest BST Subtree.
        /// </summary>
        public int MaxSum { get; set; } = Int32.MinValue;
        public int LargestBSTSubtree(TreeNode root)
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
            int sum = 1 + left.Sum + right.Sum;

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
