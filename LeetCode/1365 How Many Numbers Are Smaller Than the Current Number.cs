using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {
        /// <summary>
        /// Runtime: 220 ms, faster than 43.37% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
        /// Memory Usage: 42.2 MB, less than 80.91% of C# online submissions for How Many Numbers Are Smaller Than the Current Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                        continue;
                    if (nums[i] > nums[j])
                        result[i] = result[i] + 1;
                }
            }
            return result;
        }
    }
}
