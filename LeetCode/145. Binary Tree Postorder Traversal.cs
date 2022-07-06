using System.Collections.Generic;

namespace LeetCode
{
    public class _145__Binary_Tree_Postorder_Traversal {
        
        public class TreeNode_145
        {
            public int val;
            public TreeNode_145 left;
            public TreeNode_145 right;
            public TreeNode_145(int val = 0, TreeNode_145 left = null, TreeNode_145 right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        /// <summary>
        /// Runtime: 256 ms, faster than 12.13% of C# online submissions for Binary Tree Postorder Traversal.
        /// Memory Usage: 40.9 MB, less than 55.74% of C# online submissions for Binary Tree Postorder Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode_145 root)
        {
            List<int> result = new List<int>();
            if(root!=null)
            { 
                result = Traverse(root,result);
            }
            return result;
        }

        public static List<int> Traverse(TreeNode_145 current, List<int> result )
        {
            result.Add(current.val);
            if (current.left != null)
                Traverse(current.left, result);
            if(current.right!=null)
                Traverse(current.right, result);
            return result;
        }

    }
}