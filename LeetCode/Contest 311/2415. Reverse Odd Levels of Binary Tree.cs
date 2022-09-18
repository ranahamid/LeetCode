using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_311
{
    internal class _2415
    {
        /// <summary>
        /// Runtime: 173 ms, faster than 100.00% of C# online submissions for Reverse Odd Levels of Binary Tree.
        /// Memory Usage: 53.7 MB, less than 100.00% of C# online submissions for Reverse Odd Levels of Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            Visit(root.left, root.right, 0);
            return root;
        }
        public void Visit(TreeNode root1, TreeNode root2, int level)
        {
            if (root1 == null && root2 == null)
            {
                return;
            }
            if (level % 2 == 0)
            {
                (root1.val, root2.val) = (root2.val, root1.val);
            }
            Visit(root1.left, root2.right, level + 1);
            Visit(root2.left, root1.right, level + 1);
        }
    }
}
