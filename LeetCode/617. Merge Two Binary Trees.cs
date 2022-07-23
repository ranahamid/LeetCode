using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_617
    {
        public int val;
        public TreeNode_617 left;
        public TreeNode_617 right;
        public TreeNode_617(int val = 0, TreeNode_617 left = null, TreeNode_617 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _617
    {
        public TreeNode_617 MergeTrees(TreeNode_617 root1, TreeNode_617 root2)
        {
            if (root1 == null)
                return root2;
            if (root2 == null)
                return root1;
            root1.val = root1.val + root2.val;
            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);
            return root1;
        }
    }
}
