using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{


    public class TreeNode_1002
    {
        public int val;
        public TreeNode_1002 left;
        public TreeNode_1002 right;
        public TreeNode_1002(int val = 0, TreeNode_1002 left = null, TreeNode_1002 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _102
    {
        //Runtime: 254 ms, faster than 17.21% of C# online submissions for Binary Tree Level Order Traversal.
        // Memory Usage: 41.9 MB, less than 50.07% of C# online submissions for Binary Tree Level Order Traversal.
        public static IList<IList<int>> LevelOrder(TreeNode_1002 root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<TreeNode_1002> queue = new Queue<TreeNode_1002>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var count = 0;
                var queueLen = queue.Count();
                var currentVal = new List<int>();
                while (count < queueLen)
                {

                    TreeNode_1002 node = queue.Dequeue();
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
