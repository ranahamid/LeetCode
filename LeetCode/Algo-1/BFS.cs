using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BFS
    {
        public static TreeNode[] BFSSearch(TreeNode root)
        {
            var result = new List<TreeNode>();
            if(root == null)
                return result.ToArray();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                result.Add(node);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            return result.ToArray();
        }
    }
}
