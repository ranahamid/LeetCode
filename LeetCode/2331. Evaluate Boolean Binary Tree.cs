using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2331
    {
        public bool EvaluateTree(TreeNode root)
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
