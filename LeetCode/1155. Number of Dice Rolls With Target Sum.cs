using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1155
    {
        /// <summary>
        /// Runtime 32 ms Beats 100% Memory 27.3 MB Beats 61.25%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int NumRollsToTarget(int n, int k, int target)
        {
            var dp = new int[n + 1, target + 1];
            dp[n, target] = 1;
            int MOD = (int)Math.Pow(10, 9) + 7;
            for (int diceInd = n - 1; diceInd >= 0; diceInd--)
            {
                for (int currSum = 0; currSum <= target; currSum++)
                {
                    int ways = 0;
                    var kMin = Math.Min(k, target - currSum);
                    for (int i = 1; i <= kMin; i++)
                    {
                        ways = (ways + dp[diceInd + 1, currSum + i]) % MOD;
                    }
                    dp[diceInd, currSum] = ways;
                }
            }
            return dp[0, 0];
        }
    }
}
