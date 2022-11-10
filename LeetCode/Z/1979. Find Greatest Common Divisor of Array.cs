using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1979
    {
        /// <summary>
        /// Runtime: 81 ms, faster than 99.21% of C# online submissions for Find Greatest Common Divisor of Array.
        /// Memory Usage: 40 MB, less than 5.56% of C# online submissions for Find Greatest Common Divisor of Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindGCD(int[] nums)
        {
            Array.Sort(nums);
            var small = nums.FirstOrDefault();
            var great = nums.LastOrDefault();
            return GCD(great, small);
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return Math.Max(a, b);
        }
    }
}
