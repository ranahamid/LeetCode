using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    /// <summary>
    /// Runtime: 74 ms, faster than 9.52% of C# online submissions for Armstrong Number.
    /// Memory Usage: 28 MB, less than 28.57% of C# online submissions for Armstrong Number.
    /// </summary>
    internal class _1134
    {
        public static bool IsArmstrong(int n)
        {
            var digits = GetDigits(n);
            var sum = 0;
            var len = digits.Count();
            foreach (var digit in digits)
            {
                sum = sum + (int)Math.Pow(digit, len);
                if (sum > n)
                {
                    return false;
                }
            }
            if (sum == n)
                return true;
            return false;
        }
        public static Stack<int> GetDigits(int source)
        {
            Stack<int> digits = new Stack<int>();
            while (source > 0)
            {
                var digit = source % 10;
                digits.Push(digit);
                source = source / 10;
            }
            return digits;
        }

    }
}
