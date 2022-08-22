using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1854
    {
        /// <summary>
        /// Runtime: 142 ms, faster than 33.33% of C# online submissions for Maximum Population Year.
        /// Memory Usage: 37.6 MB, less than 38.10% of C# online submissions for Maximum Population Year.
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public int MaximumPopulation(int[][] logs)
        {
            var max = 0;
            var dp = new int[2051];
            foreach (var l in logs)
            {
                dp[l[0]]++;
                dp[l[1]]--;
            }

            for (int i = 1950; i <= 2050; i++)
            {
                dp[i] = dp[i] + dp[i - 1];
                // max=Math.Max(max, dp[i]);
                if (dp[i] > dp[max])
                {
                    max = i;
                }
            }
            return max;
        }
    }
}
