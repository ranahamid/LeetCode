using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _35_Search_Insert_Position
    {
        /// <summary>
        /// Runtime: 112 ms, faster than 59.98% of C# online submissions for Search Insert Position.
        /// Memory Usage: 37.7 MB, less than 80.67% of C# online submissions for Search Insert Position.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int SearchInsert(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            while (start <= end)
            {
                var mid = (end + start) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return start;
        }

    }
}
