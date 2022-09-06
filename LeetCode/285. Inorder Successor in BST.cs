using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _285
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode result = null;
            while (root != null)
            {
                if (p.val >= root.val)
                {
                    root = root.right;
                }
                else
                {
                    result = root;
                    root = root.left;
                }
            }
            return result;
        }

        #region in
        /// <summary>
        /// Runtime: 116 ms, faster than 85.57% of C# online submissions for Inorder Successor in BST.
        /// Memory Usage: 45.9 MB, less than 7.46% of C# online submissions for Inorder Successor in BST.
        /// </summary>
        bool isFirstFound = false;
        bool isSecondFound = false;
        TreeNode result = null;

        public TreeNode InorderSuccessor_2(TreeNode root, TreeNode p)
        {
            InOrder(root, p);
            return result;
        }

        public void InOrder(TreeNode root, TreeNode p)
        {
            if (root == null || isSecondFound)
                return;
            InOrder(root.left, p);
            if (root == p)
            {
                isFirstFound = true;
            }
            else if (isFirstFound && !isSecondFound)
            {
                isSecondFound = true;
                Console.WriteLine(root.val);
                result = root;
            }
            InOrder(root.right, p);
        }
        #endregion
        /// <summary>
        /// Runtime: 161 ms, faster than 42.79% of C# online submissions for Inorder Successor in BST.
        /// Memory Usage: 42.5 MB, less than 37.31% of C# online submissions for Inorder Successor in BST.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public TreeNode InorderSuccessor_1(TreeNode root, TreeNode p)
        {
            List<TreeNode> result = new List<TreeNode>();
            InOrder(root, result);
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] == p)
                    return result[i + 1];
            }
            return null;
        }

        public void InOrder(TreeNode root, List<TreeNode> result)
        {
            if (root == null)
                return;
            InOrder(root.left, result);
            result.Add(root);
            InOrder(root.right, result);
        }
    }
}
