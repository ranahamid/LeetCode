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

        public static IList<int> RightSideView(TreeNode root)
        {
            var result = new List<TreeNode>();
            if (root == null)
                return new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count();
                for(int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    if(i==0)
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
            return result.Select(x=>x.val).ToArray();
        }
    }
}
