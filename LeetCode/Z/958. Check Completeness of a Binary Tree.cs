using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _958
    {
        public bool IsCompleteTree_2(TreeNode root)
        {
            Queue<TreeNode> bfs = new Queue<TreeNode>();
            bfs.Enqueue(root);
            while (true)
            {
                var node = bfs.Dequeue();
                if (node.left == null)
                {
                    if (node.right != null)
                    {
                        return false;
                    }
                    break;
                }
                bfs.Enqueue(node.left);
                if (node.right == null)
                {
                    break;
                }
                bfs.Enqueue(node.right);
            }
            while (bfs.Count() > 0)
            {
                var node = bfs.Dequeue();
                if (node.left != null || node.right != null)
                    return false;
            }
            return bfs.Count() == 0;
        }
        /// <summary>
        /// Runtime 122 ms Beats 83.33% Memory 39.2 MB Beats 81.82%
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsCompleteTree_1(TreeNode root)
        {
            Queue<TreeNode> bfs = new Queue<TreeNode>();
            bfs.Enqueue(root);
            while (bfs.Peek() != null)
            {
                var node = bfs.Dequeue();
                bfs.Enqueue(node.left);
                bfs.Enqueue(node.right);
            }
            while (bfs.Count() > 0 && bfs.Peek() == null)
                bfs.Dequeue();
            return bfs.Count() == 0;
        }
    }
}
