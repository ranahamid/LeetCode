using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1672_Richest_Customer_Wealth
    {
        /// <summary>
        /// Runtime: 86 ms, faster than 96.41% of C# online submissions for Richest Customer Wealth.
        /// Memory Usage: 38.9 MB, less than 15.08% of C# online submissions for Richest Customer Wealth.
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            foreach (var item in accounts)
            {
                max = Math.Max(max, item.Sum());
            }
            return max;
        }
    }
}
