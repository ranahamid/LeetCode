using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_543
    {
        public int val;
        public TreeNode_543 left;
        public TreeNode_543 right;
        public TreeNode_543(int val = 0, TreeNode_543 left = null, TreeNode_543 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _543
    {
        /// <summary>
        /// Runtime: 129 ms, faster than 51.97% of C# online submissions for Diameter of Binary Tree.
        /// Memory Usage: 37.8 MB, less than 92.96% of C# online submissions for Diameter of Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int DiameterOfBinaryTree(TreeNode_543 root)
        {
            if (root == null)
                return 0;
            var max = 0;
            DFS(root, ref max);
            return max;
        }
        public static int DFS(TreeNode_543 node, ref int max)
        {
            if (node == null)
                return -1;
            var left = DFS(node.left, ref max);
            var right = DFS(node.right, ref max);
            var diameter = left + right + 1 + 1; //diameter
            max = Math.Max(diameter, max);
            return Math.Max(left, right) + 1;//maximum height
        }


    }
}
