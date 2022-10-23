using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_302
{
    internal class _2344
    {
        /// <summary>
        /// solved after the contest
        /// Runtime: 238 ms, faster than 100.00% of C# online submissions for Minimum Deletions to Make Array Divisible.
        ///    Memory Usage: 56.2 MB, less than 100.00% of C# online submissions for Minimum Deletions to Make Array Divisible.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="numsDivide"></param>
        /// <returns></returns>
        public static int MinOperations(int[] nums, int[] numsDivide)
        {
            var gcd = numsDivide.Aggregate(GCD);
            Array.Sort(nums);
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (gcd % nums[i] != 0)
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
            }
            return -1;
        }

        public static int GCD(int a, int b)
        {
            if (b > a)
            {
                return GCD(b, a);
            }
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
    }
}
