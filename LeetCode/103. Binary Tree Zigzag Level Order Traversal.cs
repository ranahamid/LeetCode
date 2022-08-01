using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_103
    {
        public int val;
        public TreeNode_103 left;
        public TreeNode_103 right;
        public TreeNode_103(int val = 0, TreeNode_103 left = null, TreeNode_103 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _103
    {
        /// <summary>
        /// Runtime: 203 ms, faster than 52.29% of C# online submissions for Binary Tree Zigzag Level Order Traversal.
        /// Memory Usage: 41.3 MB, less than 75.64% of C# online submissions for Binary Tree Zigzag Level Order Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode_103 root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode_103> queue = new Queue<TreeNode_103>();
            queue.Enqueue(root);
            var indexer = 0;
            while (queue.Count > 0)
            {
                indexer++;
                var count = 0;
                var queueLen = queue.Count();
                var currentVal = new List<int>();
                //while (count < queueLen)
                for(int i = 0; i < queueLen; i++)
                {
                    TreeNode_103 node = queue.Dequeue();
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
                if (indexer % 2 == 0)
                {
                    currentVal.Reverse();
                }
                result.Add(currentVal);
            }
            return result;
        }
    }
}
