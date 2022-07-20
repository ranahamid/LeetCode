using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _153
    {
        /// <summary>
        /// Runtime: 88 ms, faster than 93.40% of C# online submissions for Find Minimum in Rotated Sorted Array.
        /// Memory Usage: 38.9 MB, less than 9.72% of C# online submissions for Find Minimum in Rotated Sorted Array.
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
            if (nums[right] > nums[0])
                return nums[0]; //If the array is not rotated and the array is in ascending order, then last element > first element.

            while (left < right)
            {
                mid = left + (right - left) / 2; //Find the mid element of the array.
                if (nums[mid] > nums[mid + 1])
                    return nums[mid + 1]; //nums[mid] > nums[mid + 1] Hence, mid+1 is the smallest.
                if (nums[mid - 1] > nums[mid])
                    return nums[mid]; //nums[mid - 1] > nums[mid] Hence, mid is the smallest.
                if (nums[mid] > nums[0])
                {
                    left = mid + 1; //If mid element > first element of array this means that we need to look for the inflection point on the right of mid.
                }
                else
                {
                    right = mid - 1;//If mid element < first element of array this that we need to look for the inflection point on the left of mid.
                }
            }
            return -1;
        }
    }
}
