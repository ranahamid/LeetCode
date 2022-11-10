using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _272
    {
        /// <summary>
        /// Runtime: 193 ms, faster than 69.86% of C# online submissions for Closest Binary Search Tree Value II.
        /// Memory Usage: 45.2 MB, less than 15.07% of C# online submissions for Closest Binary Search Tree Value II.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> ClosestKValues(TreeNode root, double target, int k)
        {
            var result = new Dictionary<int, double>();
            DFS(root, target, result);
            var ans = result.OrderBy(x => x.Value).Take(k).Select(x => x.Key).ToList();
            return ans;
        }
        public void DFS(TreeNode root, double target, Dictionary<int, double> result)
        {
            if (root == null)
                return;
            var minValue = Math.Abs(root.val - target);
            result.Add(root.val, minValue);

            if (root.left != null)
            {
                DFS(root.left, target, result);
            }
            if (root.right != null)
            {
                DFS(root.right, target, result);
            }
        }
    }
}
