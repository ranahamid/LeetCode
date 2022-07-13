using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _107
    {
        /// <summary>
        /// without reverese
        /// Runtime: 169 ms, faster than 81.25% of C# online submissions for Binary Tree Level Order Traversal II.
        /// Memory Usage: 41.6 MB, less than 75.00% of C# online submissions for Binary Tree Level Order Traversal II.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
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
                result.Insert(0, currentVal);
                //result.Add(currentVal);
            }
            // result.Reverse();
            return result;
        }


        /// <summary>
        /// Runtime: 224 ms, faster than 39.29% of C# online submissions for Binary Tree Level Order Traversal II.
        /// Memory Usage: 41.8 MB, less than 46.43% of C# online submissions for Binary Tree Level Order Traversal II.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> LevelOrderBottom_2(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
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
            result.Reverse();
            return result;
        }
    }
}
