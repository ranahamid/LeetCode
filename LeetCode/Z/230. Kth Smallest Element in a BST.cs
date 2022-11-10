using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_230
    {
        public int val;
        public TreeNode_230 left;
        public TreeNode_230 right;
        public TreeNode_230(int val = 0, TreeNode_230 left = null, TreeNode_230 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _230
    {
        public int KthSmallest(TreeNode_230 root, int k)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            result.Sort();
            var res = result[k - 1];
            return res;
        }
        public static List<int> Traverse(TreeNode_230 current, List<int> result)
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
