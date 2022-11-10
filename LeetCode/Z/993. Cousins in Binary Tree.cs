using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _993
    {
        public class TreeNode_993
        {
            public int val;
            public TreeNode_993 left;
            public TreeNode_993 right;
            public TreeNode_993(int val = 0, TreeNode_993 left = null, TreeNode_993 right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public void display()
        {
            TreeNode_993 sev = new TreeNode_993(4);
            TreeNode_993 six = new TreeNode_993(3);
            TreeNode_993 five = new TreeNode_993(2, sev);
            TreeNode_993 list2 = new TreeNode_993(1, five, six);
        }
        /// <summary>
        /// Runtime: 145 ms, faster than 37.11% of C# online submissions for Cousins in Binary Tree.
        /// Memory Usage: 39.2 MB, less than 39.18% of C# online submissions for Cousins in Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsCousins(TreeNode_993 root, int x, int y)
        {
            if (root == null)
                return false;
            Queue<(TreeNode_993, TreeNode_993)> queue = new Queue<(TreeNode_993, TreeNode_993)>();

            queue.Enqueue((root, null));
            while (queue.Count > 0)
            {
                TreeNode_993 paretnX = null;
                TreeNode_993 paretnY = null;
                var queueLen = queue.Count();

                for (int i = 0; i < queueLen; i++)
                {
                    var node = queue.Dequeue();
                    if (node.Item1.val == x)
                    {
                        paretnX = node.Item2;
                        if (paretnX != null && paretnY != null && paretnX != paretnY)
                        {
                            return true;
                        }
                    }
                    if (node.Item1.val == y)
                    {
                        paretnY = node.Item2;
                        if (paretnX != null && paretnY != null && paretnX != paretnY)
                        {
                            return true;
                        }
                    }
                    if (node.Item1.left != null)
                    {
                        queue.Enqueue((node.Item1.left, node.Item1));
                    }
                    if (node.Item1.right != null)
                    {
                        queue.Enqueue((node.Item1.right, node.Item1));
                    }

                }

            }
            return false;
        }
    }
}
