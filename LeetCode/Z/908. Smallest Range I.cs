using System;
using System.Linq;

namespace LeetCode.Z
{
    public class _908__Smallest_Range_I
    {

        /// <summary>
        /// Runtime: 182 ms, faster than 40.00% of C# online submissions for Smallest Range I.
        /// Memory Usage: 40.9 MB, less than 90.00% of C# online submissions for Smallest Range I.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int SmallestRangeI(int[] nums, int k)
        {
            return Math.Max(nums.Max() - nums.Min() - 2 * k, 0);
        }
    }
}


