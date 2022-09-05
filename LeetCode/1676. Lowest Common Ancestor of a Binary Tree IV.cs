using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1676
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes)
        {
            var temp = nodes[0];                     
            for (int i = 1; i < nodes.Length; i++)
            {
                temp = CommonAncestor(root, temp, nodes[i]);
            }
            return temp;
        }
        public TreeNode CommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            var left = CommonAncestor(root.left, p, q);
            var right = CommonAncestor(root.right, p, q);
            if (left == null)
                return right;
            if (right == null)
                return left;
            return root;
        }
    }
}
