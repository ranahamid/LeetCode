using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_98
    {
        public int val;
        public TreeNode_98 left;
        public TreeNode_98 right;
        public TreeNode_98(int val = 0, TreeNode_98 left = null, TreeNode_98 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _98
    {
        #region Recursive Traversal with Valid Range
        /// <summary>
        /// Runtime: 229 ms, faster than 5.22% of C# online submissions for Validate Binary Search Tree.
        /// Memory Usage: 40.5 MB, less than 60.60% of C# online submissions for Validate Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsValidBST(TreeNode_98 root)
        {
            var result = ValidBST(root, null, null);
            return result;
        }
        public bool ValidBST(TreeNode_98 root, int? low, int? high)
        {
            if (root == null)
                return true;
            if (low != null && root.val <= low)
                return false;
            if (high != null && root.val >= high)
                return false;
            return ValidBST(root.left, low, root.val) && ValidBST(root.right, root.val, high);
        }
        #endregion
        #region inorder
        /// <summary>
        ///  Runtime: 147 ms, faster than 54.18% of C# online submissions for Validate Binary Search Tree.
        ///Memory Usage: 40.8 MB, less than 33.20% of C# online submissions for Validate Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool IsValidBST_InOrder(TreeNode_98 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            for (int i = 1; i < result.Count; i++)
            {
                if (result[i] <= result[i - 1]) //1,2,3,
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> Traverse(TreeNode_98 current, List<int> result)
        {
            if (current.left != null)
                Traverse(current.left, result);
            result.Add(current.val);
            if (current.right != null)
                Traverse(current.right, result);
            return result;
        }
        #endregion
    }
}
