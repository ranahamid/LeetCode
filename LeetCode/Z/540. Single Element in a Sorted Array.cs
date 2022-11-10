using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _540
    {
        /// <summary>
        /// Runtime: 120 ms, faster than 83.33% of C# online submissions for Single Element in a Sorted Array.
        /// Memory Usage: 45.9 MB, less than 17.31% of C# online submissions for Single Element in a Sorted Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNonDuplicate(int[] nums)
        {

            var low = 0;
            var high = nums.Length - 1;
            while (low < high)
            {
                var mid = low + (high - low) / 2;
                if (mid % 2 == 1)
                    mid--;
                if (nums[mid] == nums[mid + 1])
                {
                    low = mid + 2;
                }
                else
                {
                    high = mid;
                }
            }
            return nums[low];
        }
        /// <summary>
        /// O(n)
        /// Runtime 195 ms Beats 49.51% Memory 43.1 MB Beats 48.54%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNonDuplicate_BruteForce(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i = i + 2)
            {
                if (nums[i] != nums[i + 1])
                    return nums[i];
            }
            return nums[nums.Length - 1];
        }
    }
}
