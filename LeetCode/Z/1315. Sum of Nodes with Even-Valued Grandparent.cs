using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1315
    {
        /// <summary>
        /// Runtime 130 ms Beats 80% Memory 47.9 MB Beats 26.15%
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int SumEvenGrandparent(TreeNode root)
        {
            return dfs(root, 1, 1);
        }
        public int dfs(TreeNode root, int parent, int grand)
        {
            if (root == null)
                return 0;
            int left = dfs(root.left, root.val, parent);
            int right = dfs(root.right, root.val, parent);
            int val = grand % 2 == 0 ? root.val : 0;
            return left + right + val;
        }
    }
}
