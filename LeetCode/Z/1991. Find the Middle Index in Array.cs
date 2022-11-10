using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1991
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 87.13% of C# online submissions for Find the Middle Index in Array.
        /// Memory Usage: 38.9 MB, less than 16.83% of C# online submissions for Find the Middle Index in Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMiddleIndex(int[] nums)
        {
            var leftSum = 0;
            var sum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - leftSum - nums[i])
                    return i;
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
