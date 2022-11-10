using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_700
    {
        public int val;
        public TreeNode_700 left;
        public TreeNode_700 right;
        public TreeNode_700(int val = 0, TreeNode_700 left = null, TreeNode_700 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _700
    {
        /// <summary>
        /// Runtime: 188 ms, faster than 26.56% of C# online submissions for Search in a Binary Search Tree.
        /// Memory Usage: 41.1 MB, less than 75.36% of C# online submissions for Search in a Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public TreeNode_700 SearchBST(TreeNode_700 root, int val)
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
