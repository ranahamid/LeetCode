using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1339
    {
        List<long> allSum = new List<long>();
        public int MaxProduct(TreeNode root)
        {

            long total = TotalSum(root);
            long best = 0;
            foreach (var n in allSum)
            {

                best = Math.Max(best, n * (total - n));
            }
            return (int)(best % 1000000007);

        }
        public long TotalSum(TreeNode root)
        {
            if (root == null)
                return 0;
            long left = TotalSum(root.left);
            long right = TotalSum(root.right);
            long total = root.val + left + right;
            allSum.Add(total);
            return total;
        }
    }
}
