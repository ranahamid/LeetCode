using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_226
    {
        public int val;
        public TreeNode_226 left;
        public TreeNode_226 right;
        public TreeNode_226(int val = 0, TreeNode_226 left = null, TreeNode_226 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _226
    {
        public void display()
        {
            TreeNode_226 six = new TreeNode_226(3);
            TreeNode_226 five = new TreeNode_226(1);
            TreeNode_226 list2 = new TreeNode_226(2, five, six);
        }
        public static TreeNode_226 InvertTree(TreeNode_226 root)
        {
            if (root == null)
                return null;
            var newRoot = new TreeNode_226(root.val);
            newRoot.left = InvertTree(root.right);
            newRoot.right = InvertTree(root.left);
            return newRoot;
        }
    }
}
