using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2444
    {
        /// <summary>
        /// Runtime 290 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 50.5 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="minK"></param>
        /// <param name="maxK"></param>
        /// <returns></returns>
        public long CountSubarrays(int[] nums, int minK, int maxK)
        {
            
            int n = nums.Length;
            int minIndex = -1, maxIndex = -1, j = 0;
            long result = 0;
            for (int i = 0; i < n; i++)
            {

                if (nums[i] < minK || nums[i] > maxK)
                {
                    minIndex = -1;
                    maxIndex = -1;
                    j = i + 1;
                }
                if (nums[i] == minK)
                    minIndex = i;

                if (nums[i] == maxK)
                    maxIndex = i;

                var current = Math.Min(minIndex, maxIndex) - j + 1;
                result += Math.Max(0, current);
            }
            return result;
        }
    }
}
