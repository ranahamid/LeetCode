using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_671
    {
        public int val;
        public TreeNode_671 left;
        public TreeNode_671 right;
        public TreeNode_671(int val = 0, TreeNode_671 left = null, TreeNode_671 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _671
    {
        /// <summary>
        /// Runtime: 109 ms, faster than 70.08% of C# online submissions for Second Minimum Node In a Binary Tree.
        /// Memory Usage: 37.1 MB, less than 14.96% of C# online submissions for Second Minimum Node In a Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int FindSecondMinimumValue(TreeNode_671 root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            result.Sort();
            var set = new HashSet<int>(result);
            if (set.Count > 1)
            {
                var res = set.ElementAt(1);
                return res;
            }
            return -1;
        }
        public static List<int> Traverse(TreeNode_671 current, List<int> result)
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
