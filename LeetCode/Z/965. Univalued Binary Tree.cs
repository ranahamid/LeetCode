using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Z
{
    public class _965__Univalued_Binary_Tree
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public bool IsUnivalTree(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }

            var fistVal = result.FirstOrDefault();
            foreach (var item in result)
            {
                if (fistVal != item)
                    return false;
            }
            return true;
        }
        public static List<int> Traverse(TreeNode current, List<int> result)
        {
            if (current.left != null)
                Traverse(current.left, result);
            result.Add(current.val);
            if (current.right != null)
                Traverse(current.right, result);
            return result;
        }
    }
}