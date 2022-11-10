using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _530
    {
        /// <summary>
        /// Runtime: 154 ms, faster than 54.10% of C# online submissions for Minimum Absolute Difference in BST.
        /// Memory Usage: 40.3 MB, less than 27.05% of C# online submissions for Minimum Absolute Difference in BST.
        /// </summary>
        List<int> result = new List<int>();
        public int GetMinimumDifference(TreeNode root)
        {
            DFS(root);
            result.Sort();
            var min = int.MaxValue;
            Console.WriteLine(result[0]);
            for (int i = 1; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
                if (result[i] - result[i - 1] < min)
                {
                    min = result[i] - result[i - 1];
                    if (min == 0)
                        return 0;
                }
            }
            return min;
        }
        public void DFS(TreeNode root)
        {
            if (root == null)
                return;
            result.Add(root.val);
            DFS(root.left);
            DFS(root.right);
        }
    }
}
