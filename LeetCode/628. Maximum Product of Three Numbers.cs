using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _628
    {
        /// <summary>
        /// Runtime: 129 ms, faster than 96.15% of C# online submissions for Maximum Product of Three Numbers.
        /// Memory Usage: 50.1 MB, less than 7.69% of C# online submissions for Maximum Product of Three Numbers.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            var last3Num = nums.Skip(nums.Length - 3).Take(3).ToList();
            var max1 = last3Num[0] * last3Num[1] * last3Num[2];
            var max2 = nums[0] * nums[1] * last3Num[2];

            return Math.Max(max1, max2);
        }
    }
}
