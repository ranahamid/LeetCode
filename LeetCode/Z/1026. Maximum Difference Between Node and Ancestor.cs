using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1026
    {
        #region min, max
        public int MaxAncestorDiff(TreeNode root)
        {
            if (root == null)
                return 0;
            return DFS(root, root.val, root.val);

        }
        public int DFS(TreeNode root, int maxVal, int minVal)
        {
            if (root == null)
                return (maxVal - minVal);

            maxVal = Math.Max(maxVal, root.val);
            minVal = Math.Min(minVal, root.val);

            int left = DFS(root.left, maxVal, minVal);
            int right = DFS(root.right, maxVal, minVal);
            return Math.Max(left, right);
        }
        #endregion
        #region Recursion
        int result = 0;
        public int MaxAncestorDiff_2(TreeNode root)
        {

            if (root == null)
                return 0;
            result = 0;
            helper(root, root.val, root.val);
            return result;
        }
        public void helper(TreeNode root, int maxVal, int minVal)
        {
            if (root == null)
                return;
            int possible = Math.Max(Math.Abs(maxVal - root.val), Math.Abs(minVal - root.val));
            result = Math.Max(possible, result);
            maxVal = Math.Max(maxVal, root.val);
            minVal = Math.Min(minVal, root.val);

            helper(root.left, maxVal, minVal);
            helper(root.right, maxVal, minVal);
            return;
        }
        #endregion
    }
}
