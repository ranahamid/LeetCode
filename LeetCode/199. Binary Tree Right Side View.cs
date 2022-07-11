using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _199
    {
        /// <summary>
        /// Runtime: 161 ms, faster than 76.40% of C# online submissions for Binary Tree Right Side View.
        /// Memory Usage: 41.6 MB, less than 36.01% of C# online submissions for Binary Tree Right Side View.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(TreeNode root)
        {
            var result = new List<TreeNode>();
            if (root == null)
                return new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if (i == 0)
                    {
                        result.Add(node);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                }

            }
            return result.Select(x => x.val).ToArray();
        }
    }
}
