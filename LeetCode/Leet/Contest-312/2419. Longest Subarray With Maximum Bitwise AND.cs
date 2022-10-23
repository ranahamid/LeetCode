using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_312
{
    internal class _2419
    {
        /// <summary>
        /// Runtime: 289 ms, faster than 100.00% of C# online submissions for Longest Subarray With Maximum Bitwise AND.
        /// Memory Usage: 52.3 MB, less than 100.00% of C# online submissions for Longest Subarray With Maximum Bitwise AND.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestSubarray(int[] nums)
        {
            var max = nums.Max();
            var length = 0;
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                    length++;
                else
                    length = 0;
                result = Math.Max(result, length);
            }
            return result;
        }
    }
}
