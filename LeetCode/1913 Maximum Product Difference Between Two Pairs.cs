using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1913_Maximum_Product_Difference_Between_Two_Pairs
    {

        /// <summary>
        /// Runtime: 213 ms, faster than 13.86% of C# online submissions for Maximum Product Difference Between Two Pairs.
        /// Memory Usage: 40.1 MB, less than 86.14% of C# online submissions for Maximum Product Difference Between Two Pairs.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static int MaxProductDifference(int[] nums)
        {
            var n = nums.Length;
            Array.Sort(nums);
            return nums[n - 1] * nums[n - 2] - nums[0] * nums[1];
        }

    }
}
