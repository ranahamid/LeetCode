using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_337
    {
        public int val;
        public TreeNode_337 left;
        public TreeNode_337 right;
        public TreeNode_337(int val = 0, TreeNode_337 left = null, TreeNode_337 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _337
    {
        public int[] RobHelper(TreeNode_337 root)
        {
            if (root == null)
                return new int[] { 0, 0 };
            /*
              Use a helper function which receives a node as input and returns a two-element array, where the first element represents the maximum amount
            of money the thief can rob if starting from this node without robbing this node, and the second element represents the maximum amount of money
            the thief can rob if starting from this node and robbing this node.
             */
            var left = RobHelper(root.left);
            var right = RobHelper(root.right);
            //rob this node or not?
            var rob = root.val + left[1] + right[1];
            // if not rob...
            var notRob = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            return new int[] { rob, notRob };
        }
        public int Rob(TreeNode_337 root)
        {
            int[] answer = RobHelper(root);
            return Math.Max(answer[0], answer[1]);
        }
    }
}
