using System.Collections.Generic;

namespace LeetCode.Z
{
    public class TreeNode_144
    {
        public int val;
        public TreeNode_144 left;
        public TreeNode_144 right;
        public TreeNode_144(int val = 0, TreeNode_144 left = null, TreeNode_144 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class _144__Binary_Tree_Preorder_Traversal
    {
        /// <summary>
        /// Runtime: 284 ms, faster than 5.34% of C# online submissions for Binary Tree Preorder Traversal.
        /// Memory Usage: 40.9 MB, less than 59.92% of C# online submissions for Binary Tree Preorder Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode_144 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }

            return result;
        }

        public static List<int> Traverse(TreeNode_144 current, List<int> result)
        {
            if (current.left != null)
                Traverse(current.left, result);
            if (current.right != null)
                Traverse(current.right, result);
            result.Add(current.val);
            return result;
        }
    }
}