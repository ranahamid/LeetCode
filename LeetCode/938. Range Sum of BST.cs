using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    
    public class TreeNode_938 {
        public int val;
        public TreeNode_938 left;
        public TreeNode_938 right;
        public TreeNode_938(int val=0, TreeNode_938 left=null, TreeNode_938 right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    /// <summary>
    /// Runtime: 251 ms, faster than 47.64% of C# online submissions for Range Sum of BST.
    /// Memory Usage: 46.7 MB, less than 99.79% of C# online submissions for Range Sum of BST.
    /// </summary>
    public class _938__Range_Sum_of_BST {
        
        
        public int RangeSumBST(TreeNode_938 root, int low, int high) {
        
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            } 
            result= result.Where(x=>x>=low && x<=high).ToList();
            return result.Sum();

        }
        
        public static List<int> Traverse(TreeNode_938 current, List<int> result)
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