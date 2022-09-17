using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_87
{
    internal class _2412
    {
        /// <summary>
        /// Runtime: 766 ms, faster than 100.00% of C# online submissions for Minimum Money Required Before Transactions.
        /// Memory Usage: 58.3 MB, less than 100.00% of C# online submissions for Minimum Money Required Before Transactions.
        /// </summary>
        /// <param name="transactions"></param>
        /// <returns></returns>
        public long MinimumMoney(int[][] transactions)
        {
            long result = 0;
            long max = 0;
            foreach (var item in transactions)
            {
                var diff = item[0] - item[1];
                result += Math.Max(0, diff);

                var min = Math.Min(item[0], item[1]);
                max = Math.Max(max, min);
            }
            return result + max;
        }
    }
}
