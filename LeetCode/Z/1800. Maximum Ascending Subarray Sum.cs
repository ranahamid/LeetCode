using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1800
    {
        /// <summary>
        /// Runtime: 145 ms, faster than 6.82% of C# online submissions for Maximum Ascending Subarray Sum.
        /// Memory Usage: 36.8 MB, less than 68.18% of C# online submissions for Maximum Ascending Subarray Sum.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxAscendingSum(int[] nums)
        {
            var result = nums[0];
            var sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    sum += nums[i];
                }
                else
                {
                    sum = nums[i];
                }
                result = Math.Max(result, sum);
            }
            return result;
        }
    }
}
