using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2006_Count_Number_of_Pairs_With_Absolute_Difference_K
    {

        /// <summary>
        /// Runtime: 145 ms, faster than 36.65% of C# online submissions for Count Number of Pairs With Absolute Difference K.
        /// Memory Usage: 37.6 MB, less than 97.91% of C# online submissions for Count Number of Pairs With Absolute Difference K.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int CountKDifference(int[] nums, int k)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                        counter++;
                }
            }
            return counter;
        }

    }
}
