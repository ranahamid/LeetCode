using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _222
    {

        /// <summary>
        /// Runtime 133 ms Beats 75.35% Memory 41.7 MB Beats 54.23%
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int CountNodes(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + CountNodes(root.left) + CountNodes(root.right);
        }
    }
}
