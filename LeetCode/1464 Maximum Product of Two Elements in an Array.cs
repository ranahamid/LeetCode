using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1464_Maximum_Product_of_Two_Elements_in_an_Array
    {
        /// <summary>
        /// Runtime: 134 ms, faster than 36.18% of C# online submissions for Maximum Product of Two Elements in an Array.
        /// Memory Usage: 38 MB, less than 25.66% of C# online submissions for Maximum Product of Two Elements in an Array.
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
