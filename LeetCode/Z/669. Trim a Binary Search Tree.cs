using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _669
    {
        #region self
        public TreeNode TrimBST_1(TreeNode root, int low, int high)
        {
            if (root == null)
                return null;


            if (root.val >= low && root.val <= high)
            {
                root.left = TrimBST_1(root.left, low, high);
                root.right = TrimBST_1(root.right, low, high);
            }
            else if (root.val < low)
            {
                return TrimBST_1(root.right, low, high);
            }
            else if (root.val > high)
            {
                return TrimBST_1(root.left, low, high);
            }
            return root;
        }
        #endregion
        /// <summary>
        /// Runtime: 97 ms, faster than 94.74% of C# online submissions for Trim a Binary Search Tree.
        /// Memory Usage: 42.2 MB, less than 15.79% of C# online submissions for Trim a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return root;

            if (root.val > high)
                return TrimBST(root.left, low, high);

            if (root.val < low)
                return TrimBST(root.right, low, high);

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);

            return root;
        }
    }
}
