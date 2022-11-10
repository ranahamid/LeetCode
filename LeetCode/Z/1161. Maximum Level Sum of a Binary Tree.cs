using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_1161
    {
        public int val;
        public TreeNode_1161 left;
        public TreeNode_1161 right;
        public TreeNode_1161(int val = 0, TreeNode_1161 left = null, TreeNode_1161 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _1161
    {
        public int LevelOrder(TreeNode_1161 root)
        {

            if (root == null)
                return 0;
            var maxVal = int.MinValue;
            var maxIndex = -1;
            var counter = 1;
            Queue<TreeNode_1161> queue = new Queue<TreeNode_1161>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var sum = 0;
                while (count < queueLen)
                {

                    TreeNode_1161 node = queue.Dequeue();
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
