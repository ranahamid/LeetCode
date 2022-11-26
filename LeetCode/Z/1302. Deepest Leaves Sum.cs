using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1302
    {
        #region leve 2- save space
        public int DeepestLeavesSum(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var currentVal = new List<int>();
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                currentVal = new List<int>();
                while (count < queueLen)
                {

                    TreeNode node = queue.Dequeue();
                    currentVal.Add(node.val);
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
            }
            return currentVal.Sum();
        }
        #endregion
        #region level 1 

        public int DeepestLeavesSum_1(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var currentVal = new List<int>();
                while (count < queueLen)
                { 
                    TreeNode node = queue.Dequeue();
                    currentVal.Add(node.val);
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
                result.Add(currentVal);
            }
            return result.LastOrDefault().Sum();
        }
        #endregion
    }
}
