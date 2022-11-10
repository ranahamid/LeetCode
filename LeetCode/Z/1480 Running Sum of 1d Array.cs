using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1480_Running_Sum_of_1d_Array
    {
        /// <summary>
        /// Runtime: 197 ms, faster than 47.13% of C# online submissions for Running Sum of 1d Array.
        // Memory Usage: 41.9 MB, less than 32.31% of C# online submissions for Running Sum of 1d Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] RunningSum(int[] nums)
        {
            int len = nums.Length;
            for (int i = 1; i < len; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
    }
}
