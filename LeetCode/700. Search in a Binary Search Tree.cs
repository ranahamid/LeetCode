using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _700
    {
        /// <summary>
        /// Runtime: 188 ms, faster than 26.56% of C# online submissions for Search in a Binary Search Tree.
        /// Memory Usage: 41.1 MB, less than 75.36% of C# online submissions for Search in a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null && root.val != val)
            {
                if (val < root.val)
                    root = root.left;
                else
                    root = root.right;
            }
            return root;
        }
    }
}
