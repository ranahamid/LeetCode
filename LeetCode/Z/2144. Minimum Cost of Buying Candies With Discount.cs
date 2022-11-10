using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2144
    {
        /// <summary>
        /// Runtime: 92 ms, faster than 82.00% of C# online submissions for Minimum Cost of Buying Candies With Discount.
        /// Memory Usage: 38.9 MB, less than 12.00% of C# online submissions for Minimum Cost of Buying Candies With Discount.
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int MinimumCost(int[] cost)
        {
            //Reverse Sort
            Array.Sort(cost, (a, b) => b.CompareTo(a));
            var result = 0;
            for (int i = 1; i <= cost.Length; i++)
            {
                if (i % 3 != 0)
                {
                    result += cost[i - 1];
                }
            }
            return result;
        }
    }
}
