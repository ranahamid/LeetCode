using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1827_Minimum_Operations_to_Make_the_Array_Increasing
    {

        /// <summary>
        /// Runtime: 109 ms, faster than 86.42% of C# online submissions for Minimum Operations to Make the Array Increasing.
        /// Memory Usage: 39.2 MB, less than 97.53% of C# online submissions for Minimum Operations to Make the Array Increasing.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinOperations(int[] nums)
        {
            var counter = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= nums[i - 1])
                {
                    var diff = nums[i - 1] + 1 - nums[i];
                    counter += diff;
                    nums[i] = nums[i - 1] + 1;
                }
            }
            return counter;
        }
    }
}
