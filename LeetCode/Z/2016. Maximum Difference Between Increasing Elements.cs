using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2016
    {
        /// <summary>
        /// Runtime: 120 ms, faster than 65.06% of C# online submissions for Maximum Difference Between Increasing Elements.
        /// Memory Usage: 37.3 MB, less than 97.59% of C# online submissions for Maximum Difference Between Increasing Elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumDifference(int[] nums)
        {
            var max = -1;
            var minValue = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                minValue = Math.Min(minValue, nums[i]);
                max = Math.Max(max, nums[i] - minValue);
            }
            return max == 0 ? -1 : max;
        }

        /// <summary>
        /// Runtime: 110 ms, faster than 71.08% of C# online submissions for Maximum Difference Between Increasing Elements.
        /// Memory Usage: 37.5 MB, less than 74.70% of C# online submissions for Maximum Difference Between Increasing Elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumDifference_2(int[] nums)
        {
            var max = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i])
                        max = Math.Max(max, nums[j] - nums[i]);
                }
            }
            return max;
        }
    }
}
