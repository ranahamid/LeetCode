using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_1022
    {
        public int val;
        public TreeNode_1022 left;
        public TreeNode_1022 right;
        public TreeNode_1022(int val = 0, TreeNode_1022 left = null, TreeNode_1022 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _1022
    {
        int total = 0;
        public void DFS(TreeNode_1022 root, int n)
        {
            if (root != null)
            {
                n = (n << 1) | root.val;
                if (root.left == null && root.right == null)
                {
                    total += n;
                }
                DFS(root.left, n);
                DFS(root.right, n);
            }

        }
        public int SumRootToLeaf(TreeNode_1022 root)
        {
            DFS(root, 0);
            return total;
        }
    }
}
