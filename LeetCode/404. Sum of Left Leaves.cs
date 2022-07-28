using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_404
    {
        public int val;
        public TreeNode_404 left;
        public TreeNode_404 right;
        public TreeNode_404(int val = 0, TreeNode_404 left = null, TreeNode_404 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _404
    {
        public static int sum = 0;
        public int SumOfLeftLeaves(TreeNode_404 root)
        {
            sum = 0;
            if (root != null)
            {
                Traverse(root, null);
            }
            return sum;
        }
        public static void Traverse(TreeNode_404 root, TreeNode_404 mainRoot)
        {
            if (root == null)
                return;
            if (root.left == null && root.right == null && mainRoot != null && root == mainRoot.left)
                sum += root.val;

            if (root.left != null)
                Traverse(root.left, root);
            if (root.right != null)
                Traverse(root.right, root);

        }
    }
}
