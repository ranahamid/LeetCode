using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1464_Maximum_Product_of_Two_Elements_in_an_Array
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 86.18% of C# online submissions for Maximum Product of Two Elements in an Array.
        /// Memory Usage: 37.8 MB, less than 45.39% of C# online submissions for Maximum Product of Two Elements in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxProduct(int[] nums)
        {
            Array.Sort(nums);
            var secondLast = nums[nums.Length - 2] - 1;
            var last = nums[nums.Length - 1] - 1;
            return secondLast * last;
        }

    }
}
