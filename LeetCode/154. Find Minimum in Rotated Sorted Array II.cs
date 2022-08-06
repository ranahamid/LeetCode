using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _154
    {  /// <summary>
       /// Runtime: 114 ms, faster than 66.81% of C# online submissions for Find Minimum in Rotated Sorted Array II.
        /// Memory Usage: 37.8 MB, less than 68.53% of C# online submissions for Find Minimum in Rotated Sorted Array II.
       /// </summary>
       /// <param name="nums"></param>
       /// <returns></returns>
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            var left = 0;
            var right = nums.Length - 1;
            var mid = 0;


            while (left < right)
            {
                mid = left + (right - left) / 2; //Find the mid element of the array.
                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right--;
                }
            }
            return nums[left];
        }
    }
}
