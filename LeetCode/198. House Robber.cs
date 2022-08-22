using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _198
    {
        #region two variable 
        /// <summary>
        /// Runtime: 81 ms, faster than 97.66% of C# online submissions for House Robber.
        /// Memory Usage: 37.8 MB, less than 13.19% of C# online submissions for House Robber.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
          
            int prev1 = 0;
            int prev2 = 0;
            foreach (var num in nums)
            {
                int temp = prev1;
                prev1 = Math.Max(num + prev2, prev1);
                prev2 = temp;
            }
            return prev1;
        }
        #endregion
        #region iterative 
        /// <summary>
        /// Runtime: 133 ms, faster than 36.99% of C# online submissions for House Robber.
        /// Memory Usage: 36.6 MB, less than 73.39% of C# online submissions for House Robber.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob_2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int[] memo = new int[nums.Length + 1];
            memo[0] = 0;
            memo[1] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                memo[i + 1] = Math.Max(nums[i] + memo[i - 1], memo[i]);
            }

            return memo[nums.Length];
        }
        #endregion
        #region recursion
        /// <summary>
        /// Runtime: 122 ms, faster than 50.53% of C# online submissions for House Robber.
        /// Memory Usage: 36.8 MB, less than 42.50% of C# online submissions for House Robber.
        /// </summary>
        public static int[] memo;
        public int Rob_1(int[] nums)
        {
            memo = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                memo[i] = -1;
            }
            return Rob(nums, nums.Length - 1);
        }
        public int Rob(int[] nums, int i)
        {
            if (i < 0)
                return 0;
            if (memo[i] >= 0)
                return memo[i];
            var result = Math.Max(nums[i] + Rob(nums, i - 2), Rob(nums, i - 1));
            memo[i] = result;
            return result;
        }
        #endregion
    }
}
