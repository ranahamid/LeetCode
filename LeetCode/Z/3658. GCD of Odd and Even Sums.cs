using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _3658
    {
        public int GcdOfOddEvenSums(int n)
        {
            var oddSum = n * n;
            var even = n * (n + 1);

            return GCD(oddSum, even);
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
