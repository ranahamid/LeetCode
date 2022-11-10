using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1382
    {
        /// <summary>
        /// Runtime: 201 ms, faster than 47.37% of C# online submissions for Balance a Binary Search Tree.
        /// dMemory Usage: 46 MB, less than 45.61% of C# online submissions for Balance a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode BalanceBST(TreeNode root)
        {
            var result = new List<TreeNode>();
            InOrder(root, result);
            return MakeBST(result, 0, result.Count - 1);
        }
        public TreeNode MakeBST(List<TreeNode> result, int start, int end)
        {
            if (start > end)
                return null;
            var mid = start + (end - start) / 2;
            var root = result[mid];
            root.left = MakeBST(result, start, mid - 1);
            root.right = MakeBST(result, mid + 1, end);
            return root;
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
