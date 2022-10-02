using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1155
    {
        #region Top    
        /// <summary>
        /// Runtime 31 ms Beats 100% Memory 28.8 MB
        /// </summary>
        /// <param name="dp"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="target"></param>
        /// <param name="currentIndex"></param>
        /// <param name="currentSum"></param>
        /// <returns></returns>
        public int NumberOfWays(int?[,] dp, int n, int k, int target, int currentIndex, int currentSum)
        {
            int MOD = (int)Math.Pow(10, 9) + 7;
            if (currentIndex == n)
            {
                if (currentSum == target)
                    return 1;
                return 0;
            }
            if (dp[currentIndex, currentSum] != null)
                return (int)dp[currentIndex, currentSum];

            var kMin = Math.Min(k, target - currentSum);
            int ways = 0;
            for (int i = 1; i <= kMin; i++)
            {
                ways = (ways + NumberOfWays(dp, n, k, target, currentIndex + 1, currentSum + i)) % MOD;
            }
            dp[currentIndex, currentSum] = ways;
            return ways;
        }
        public int NumRollsToTarget(int n, int k, int target)
        {
            var dp = new int?[n + 1, target + 1];
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < target + 1; j++)
                {
                    dp[i, j] = null;
                }
            }
            return NumberOfWays(dp, n, k, target, 0, 0);
        }
        #endregion
        #region Bottom
        /// <summary>
        /// Runtime 32 ms Beats 100% Memory 27.3 MB Beats 61.25%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int NumRollsToTarget_1(int n, int k, int target)
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
        #endregion
    }
}
