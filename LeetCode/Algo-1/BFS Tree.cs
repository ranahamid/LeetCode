using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_BFSTree
    {
        public int val;
        public TreeNode_BFSTree left;
        public TreeNode_BFSTree right;
        public TreeNode_BFSTree(int val = 0, TreeNode_BFSTree left = null, TreeNode_BFSTree right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class BFS
    {
        public static TreeNode_BFSTree[] BFSSearch(TreeNode_BFSTree root)
        {
            var result = new List<TreeNode_BFSTree>();
            if(root == null)
                return result.ToArray();
            Queue<TreeNode_BFSTree> queue = new Queue<TreeNode_BFSTree>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                TreeNode_BFSTree node = queue.Dequeue();
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

        public static IList<int> RightSideView(TreeNode_BFSTree root)
        {
            var result = new List<TreeNode_BFSTree>();
            if (root == null)
                return new List<int>();
            Queue<TreeNode_BFSTree> queue = new Queue<TreeNode_BFSTree>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var size = queue.Count();
                for(int i = 0; i < size; i++)
                {
                    TreeNode_BFSTree node = queue.Dequeue();
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
