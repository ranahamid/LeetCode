using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1512_Number_of_Good_Pairs
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 84.63% of C# online submissions for Number of Good Pairs.
        /// Memory Usage: 38 MB, less than 13.66% of C# online submissions for Number of Good Pairs.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int NumIdenticalPairs(int[] nums)
        {
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        counter++;
                }
            }
            return counter;
        }
    }
}
