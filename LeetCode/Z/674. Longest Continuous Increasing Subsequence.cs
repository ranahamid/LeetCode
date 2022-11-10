using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _674
    {
        /// <summary>
        /// Runtime 159 ms Beats 42.48% Memory 38.5 MB Beats 88.50%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLengthOfLCIS(int[] nums)
        {
            var max = 1;
            var currentMax = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    currentMax++;
                else
                    currentMax = 1;
                max = Math.Max(max, currentMax);
            }
            return max;
        }
    }
}
