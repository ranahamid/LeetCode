using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1305
    {
        #region self
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            InOrder(root1, result1);
            InOrder(root2, result2);
            result1.AddRange(result2);
            result1.Sort();
            return result1;
        }
        public void InOrder(TreeNode root, List<int> result)
        {
            if (root == null)
                return;
            InOrder(root.left, result);
            result.Add(root.val);
            InOrder(root.right, result);
        }
        #endregion
    }
}
