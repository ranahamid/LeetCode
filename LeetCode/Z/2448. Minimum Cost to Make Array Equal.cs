using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2448
    {
        /// <summary>
        /// Runtime 563 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 50.6 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="cost"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public long GetCost(int[] nums, int[] cost, int x)
        {
            long result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += (long)Math.Abs(nums[i] - x) * cost[i];
            }
            return result;
        }
        public long MinCost(int[] nums, int[] cost)
        {
            long result = GetCost(nums, cost, 1);
            var left = nums.Min();
            var right = nums.Max();
            left = Math.Min(left, 1);
            right = Math.Max(right, 1000000);
            while (left < right)
            {
                var mid = (left + right) / 2;
                var y1 = GetCost(nums, cost, mid);
                var y2 = GetCost(nums, cost, mid + 1);
                result = Math.Min(y1, y2);

                if (y1 < y2)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return result;
        }
    }
}
