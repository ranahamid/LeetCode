using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _724
    {
        /// <summary>
        /// Runtime: 197 ms, faster than 29.46% of C# online submissions for Find Pivot Index.
        /// Memory Usage: 39.6 MB, less than 87.39% of C# online submissions for Find Pivot Index.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int PivotIndex(int[] nums)
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
