using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _377
    {
        public int CombinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            dp[0] = 1;
            for (int i = 0; i < target; i++)
            {
                foreach (var n in nums)
                {
                    var sum = i + n;
                    if (sum <= target)
                    {
                        dp[sum] += dp[i];
                    }
                }
            }
            return dp[target];
        }
        #region top down

        /// <summary>
        /// Runtime: 140 ms, faster than 32.37% of C# online submissions for Combination Sum IV.
        /// Memory Usage: 36.5 MB, less than 88.41% of C# online submissions for Combination Sum IV.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int CombinationSum4_Top(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            return Combination(nums, dict, target);
        }
        public static int Combination(int[] nums, Dictionary<int, int> dict, int target)
        {
            if (target == 0)
                return 1;
            if (dict.ContainsKey(target))
                return dict[target];

            var result = 0;
            foreach (var n in nums)
            {
                if (target >= n)
                {
                    result = result + Combination(nums, dict, target - n);
                }
            }
            dict[target] = result;
            return result;
        }
        #endregion
        #region bottom up

        /// <summary>
        /// Bottom Up
        /// Runtime: 143 ms, faster than 28.98% of C# online submissions for Combination Sum IV.
        /// Memory Usage: 36.8 MB, less than 61.35% of C# online submissions for Combination Sum IV.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int CombinationSum4_BottomUp(int[] nums, int target)
        {
            var dp = new int[target + 1];
            dp[0] = 1;
            for (int targetSum = 1; targetSum <= target; targetSum++)
            {
                foreach (var n in nums)
                {
                    if (targetSum >= n)
                    {
                        dp[targetSum] = dp[targetSum] + dp[targetSum - n];
                    }
                }
            }
            return dp[target];
        }
        #endregion
    }
}
