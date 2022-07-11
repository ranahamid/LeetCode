using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_BFS
    {
        public int val;
        public TreeNode_BFS left;
        public TreeNode_BFS right;
        public TreeNode_BFS(int val = 0, TreeNode_BFS left = null, TreeNode_BFS right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class BFSLEVEL
    {
        public static IList<IList<int>> LevelOrder(TreeNode_BFS root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode_BFS> queue = new Queue<TreeNode_BFS>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var currentVal = new List<int>();
                while (count < queueLen)
                {

                    TreeNode_BFS node = queue.Dequeue();
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
            return result;
        }
    }
}
