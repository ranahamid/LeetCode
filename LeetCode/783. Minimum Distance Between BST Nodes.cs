using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _783
    {
        /// <summary>
        /// Runtime: 132 ms, faster than 32.95% of C# online submissions for Minimum Distance Between BST Nodes.
       ///  Memory Usage: 37.3 MB, less than 17.05% of C# online submissions for Minimum Distance Between BST Nodes.
        /// </summary>
        List<int> result = new List<int>();
        public int MinDiffInBST(TreeNode root)
        {
            DFS(root);
            result.Sort();
            var min = Int32.MaxValue;
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
