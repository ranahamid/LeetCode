using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2256
    {
        /// <summary>
        /// Runtime 440 ms Beats 41.86% Memory 49.2 MB Beats 20.93%
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinimumAverageDifference(int[] nums)
        {
            long sum = 0;
            int n = nums.Length;
            foreach (var item in nums)
                sum += item;

            int ans = -1;
            int minDiff = Int32.MaxValue;
            long currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];

                long leftAvg = currentSum;
                leftAvg /= (i + 1);

                long rightAvg = sum - currentSum;
                if (i != n - 1)
                {
                    rightAvg /= (nums.Length - (i + 1));
                }
                int diff = (int)Math.Abs(rightAvg - leftAvg);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    ans = i;
                }

            }

            return ans;

        }
    }
}
