using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_701
    {
        public int val;
        public TreeNode_701 left;
        public TreeNode_701 right;
        public TreeNode_701(int val = 0, TreeNode_701 left = null, TreeNode_701 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _701
    {
        /// <summary>
        /// Runtime: 195 ms, faster than 31.16% of C# online submissions for Insert into a Binary Search Tree.
        /// Memory Usage: 42.9 MB, less than 96.14% of C# online submissions for Insert into a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode_701 InsertIntoBST(TreeNode_701 root, int val)
        {
            if (root == null)
                return new TreeNode_701(val);
            if (val > root.val)
                root.right = InsertIntoBST(root.right, val);
            else if (val < root.val)
                root.left = InsertIntoBST(root.left, val);
            return root;
        }
    }
}
