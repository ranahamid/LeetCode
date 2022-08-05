using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1984
    {

        /// <summary>
        /// Runtime: 107 ms, faster than 89.47% of C# online submissions for Minimum Difference Between Highest and Lowest of K Scores.
        /// Memory Usage: 39.8 MB, less than 56.14% of C# online submissions for Minimum Difference Between Highest and Lowest of K Scores.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MinimumDifference(int[] nums, int k)
        {
            var min = Int32.MaxValue;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - k + 1; i++)
            {
                min = Math.Min(min, nums[i + k - 1] - nums[i] );
            } 
            return min;
        }
        /// <summary>
        /// Runtime: 146 ms, faster than 54.39% of C# online submissions for Minimum Difference Between Highest and Lowest of K Scores.
        /// Memory Usage: 39.9 MB, less than 40.35% of C# online submissions for Minimum Difference Between Highest and Lowest of K Scores.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int MinimumDifference_(int[] nums, int k)
        {
            var min = Int32.MaxValue;
            Array.Sort(nums);

            for (int i = k - 1; i < nums.Length; i++)
            {
                min = Math.Min(min, nums[i] - nums[i - k + 1]);
            }
            return min;
        }
    }
}
