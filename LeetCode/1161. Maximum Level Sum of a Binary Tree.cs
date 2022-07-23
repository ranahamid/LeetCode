using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1161
    {
        public int LevelOrder(TreeNode root)
        {

            if (root == null)
                return 0;
            var maxVal = Int32.MinValue;
            var maxIndex = -1;
            var counter = 1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var sum = 0;
                while (count < queueLen)
                {

                    TreeNode node = queue.Dequeue();
                    sum += node.val;

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
                if (sum > maxVal)
                {
                    maxVal = sum;
                    maxIndex = counter;
                }
                counter++;
            }
            return maxIndex;
        }
    }
}
