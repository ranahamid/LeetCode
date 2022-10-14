using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1824
    {
        /// <summary>
        /// Runtime 868 ms Beats 33.33% Memory 55.9 MB Beats 66.67%
        /// </summary>
        /// <param name="obstacles"></param>
        /// <returns></returns>
        public int MinSideJumps(int[] obstacles)
        {
            var dp = new int[3];
            dp[0] = 1;
            dp[1] = 0;
            dp[2] = 1;
            foreach (var item in obstacles)
            {
                if (item > 0)
                    dp[item - 1] = (int)Math.Pow(10, 6);
                for (int i = 0; i < 3; i++)
                {
                    if (item != i + 1)
                    {
                        var temp = Math.Min(dp[(i + 1) % 3], dp[(i + 2) % 3]);
                        dp[i] = Math.Min(dp[i], temp + 1);
                    }
                }
            }
            return dp.Min();
        }
    }
}
