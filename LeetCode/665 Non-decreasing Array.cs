using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _665_Non_decreasing_Array
    {

        /// <summary>
        /// Runtime: 125 ms, faster than 96.51% of C# online submissions for Non-decreasing Array.
        /// Memory Usage: 49 MB, less than 9.30% of C# online submissions for Non-decreasing Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>

        public static bool CheckPossibility(int[] nums)
        {
            var counter = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] >= nums[i - 1])
                    continue;
                else
                {
                    counter++;
                    if (counter > 1)
                        return false;
                    if (i == 1 || nums[i - 2] <= nums[i])
                        nums[i - 1] = nums[i];
                    else
                        nums[i] = nums[i - 1];
                }
            }
            return true;
        }
    }
}
