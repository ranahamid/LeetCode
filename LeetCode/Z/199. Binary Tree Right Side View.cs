using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_199
    {
        public int val;
        public TreeNode_199 left;
        public TreeNode_199 right;
        public TreeNode_199(int val = 0, TreeNode_199 left = null, TreeNode_199 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _199
    {
        /// <summary>
        /// Runtime: 161 ms, faster than 76.40% of C# online submissions for Binary Tree Right Side View.
        /// Memory Usage: 41.6 MB, less than 36.01% of C# online submissions for Binary Tree Right Side View.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(TreeNode_199 root)
        {
            var result = new List<TreeNode_199>();
            if (root == null)
                return new List<int>();
            Queue<TreeNode_199> queue = new Queue<TreeNode_199>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    TreeNode_199 node = queue.Dequeue();
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
