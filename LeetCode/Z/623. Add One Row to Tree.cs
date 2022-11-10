using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _623
    {
        /// <summary>
        /// Runtime 104 ms Beats 87.10% Memory 40.7 MB Beats 9.68%
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <param name="depth"></param>
        /// <returns></returns>
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                var t = new TreeNode(val);
                t.left = root;
                return t;
            }
            Insert(root, val, depth, 1);
            return root;
        }
        public void Insert(TreeNode root, int val, int depth, int d)
        {
            if (root == null)
                return;
            if (d == depth - 1)
            {
                var t = root.left;
                root.left = new TreeNode(val);
                root.left.left = t;

                var r = root.right;
                root.right = new TreeNode(val);
                root.right.right = r;
            }
            else
            {
                Insert(root.left, val, depth, d + 1);
                Insert(root.right, val, depth, d + 1);
            }
        }
    }
}
