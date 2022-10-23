using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_316
{
    internal class _2447
    {
        /// <summary>
        /// Runtime 188 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 38 MB Beats 100%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarrayGCD(int[] nums, int k)
        {
            var count = 0;
            var n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                var current = 0;
                for (int j = i; j < n; j++)
                {

                    current = GCD(current, nums[j]);
                    if (current == k)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
        public static int GCD(int left, int right)
        {
            if (right > left)
            {
                return GCD(right, left);
            }
            if (right == 0)
            {
                return left;
            }
            return GCD(right, left % right);
        }
    }
}
