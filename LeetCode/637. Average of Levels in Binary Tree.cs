using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _637
    {
        /// <summary>
        /// Runtime: 149 ms, faster than 97.64% of C# online submissions for Average of Levels in Binary Tree.
        /// Memory Usage: 45.6 MB, less than 15.35% of C# online submissions for Average of Levels in Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var result = new List<double>();
            if (root == null)
                return result;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                long currentVal = 0;

                while (count < queueLen)
                {
                    TreeNode node = queue.Dequeue();
                    currentVal += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    count++;
                }
                var val = currentVal / (double)count;
                result.Add(val);
            }
            return result;
        }
    }
}
