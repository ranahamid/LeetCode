using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _896
    {
        /// <summary>
        /// Runtime: 447 ms, faster than 27.86% of C# online submissions for Monotonic Array.
        /// Memory Usage: 52.9 MB, less than 41.10% of C# online submissions for Monotonic Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1)
                return true;
            var increasing = -1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                    continue;
                if (nums[i] > nums[i - 1])
                {
                    if (increasing == 0)
                    {
                        return false;
                    }
                    increasing = 1;
                }
                else
                {
                    if (increasing == 1)
                    {
                        return false;
                    }
                    increasing = 0;
                }
            }
            return true;
        }

    }
}
