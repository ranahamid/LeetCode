using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class TreeNode_298
    {
        public int val;
        public TreeNode_298 left;
        public TreeNode_298 right;
        public TreeNode_298(int val = 0, TreeNode_298 left = null, TreeNode_298 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _298
    {
        public static int max = 0;
        public int LongestConsecutive(TreeNode_298 root)
        {
            max = 0;
            DFS(root);
            return max;
        }
        public static int DFS(TreeNode_298 root)
        {
            if (root == null)
                return 0;
            var left = DFS(root.left) + 1;
            var right = DFS(root.right) + 1;

            if (root.left != null && root.val + 1 != root.left.val)
                left = 1;
            if (root.right != null && root.val + 1 != root.right.val)
                right = 1;


            var localMax = Math.Max(left, right);
            max = Math.Max(max, localMax);
            return localMax;
        }
    }
}
