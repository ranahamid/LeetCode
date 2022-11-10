using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1909
    {
        /// <summary>
        /// Runtime: 149 ms, faster than 50.00% of C# online submissions for Remove One Element to Make the Array Strictly Increasing.
        /// Memory Usage: 39.3 MB, less than 76.25% of C# online submissions for Remove One Element to Make the Array Strictly Increasing.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool CanBeIncreasing(int[] nums)
        {
            var counter = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    if (i - 2 >= 0 && nums[i - 2] >= nums[i])
                    {
                        nums[i] = nums[i - 1];
                    }
                    counter++;
                }
                if (counter == 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
