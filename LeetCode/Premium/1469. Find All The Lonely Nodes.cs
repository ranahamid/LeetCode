using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class TreeNode_1469
    {
        public int val;
        public TreeNode_1469 left;
        public TreeNode_1469 right;
        public TreeNode_1469(int val = 0, TreeNode_1469 left = null, TreeNode_1469 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _1469
    {
        public static IList<int> GetLonelyNodes(TreeNode_1469 root)
        {
            var result = new List<int>();
            if (root == null)
                return result.ToArray();
            Queue<TreeNode_1469> queue = new Queue<TreeNode_1469>();
            queue.Enqueue(root);
            result.Add(root.val);
            while (queue.Count > 0)
            {
                TreeNode_1469 node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                if (node.left != null && node.right == null)
                {
                    result.Add(node.left.val);
                }
                if (node.right != null && node.left == null)
                {
                    result.Add(node.right.val);
                }
            }
            return result.ToArray();
        }
    }
}
