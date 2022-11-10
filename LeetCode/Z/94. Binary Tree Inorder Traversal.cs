using System.Collections.Generic;

namespace LeetCode.Z
{
    public class TreeNode_94
    {
        public int val;
        public TreeNode_94 left;
        public TreeNode_94 right;
        public TreeNode_94(int val = 0, TreeNode_94 left = null, TreeNode_94 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    /// <summary>
    /// Runtime: 275 ms, faster than 6.52% of C# online submissions for Binary Tree Inorder Traversal.
    /// Memory Usage: 40.7 MB, less than 76.21% of C# online submissions for Binary Tree Inorder Traversal.
    /// </summary>
    public class _94__Binary_Tree_Inorder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode_94 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }

            return result;
        }

        public static List<int> Traverse(TreeNode_94 current, List<int> result)
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