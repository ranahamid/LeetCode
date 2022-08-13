using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_897
    {
        public int val;
        public TreeNode_897 left;
        public TreeNode_897 right;
        public TreeNode_897(int val = 0, TreeNode_897 left = null, TreeNode_897 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _897
    {
        /// <summary>
        /// Runtime: 155 ms, faster than 23.65% of C# online submissions for Increasing Order Search Tree.
        /// Memory Usage: 36.6 MB, less than 81.08% of C# online submissions for Increasing Order Search Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode_897 IncreasingBST(TreeNode_897 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            TreeNode_897 ans = new TreeNode_897(0);
            var temp = ans;
            foreach (var val in result)
            {
                temp.right = new TreeNode_897(val);
                temp = temp.right;
            }

            return ans.right;
        }
        public static List<int> Traverse(TreeNode_897 current, List<int> result)
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
