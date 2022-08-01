using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_2331
    {
        public int val;
        public TreeNode_2331 left;
        public TreeNode_2331 right;
        public TreeNode_2331(int val = 0, TreeNode_2331 left = null, TreeNode_2331 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _2331
    {
        public bool EvaluateTree(TreeNode_2331 root)
        {
            if (root.val == 0 || root.val == 1)
            {
                return root.val == 1 ? true : false;
            }
            if (root.val == 2)
            {
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            }

            return EvaluateTree(root.left) && EvaluateTree(root.right);

        }

    }
}
