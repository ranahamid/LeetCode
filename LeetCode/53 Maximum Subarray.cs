using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _53_Maximum_Subarray
    {

        /// <summary>
        /// Runtime: 316 ms, faster than 38.81% of C# online submissions for Maximum Subarray.
        /// Memory Usage: 48.4 MB, less than 71.36% of C# online submissions for Maximum Subarray.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                max = Math.Max(max, sum);
                if (sum < 0)
                {
                    sum = 0;
                }
            }
            return max;
        }

    }
}
