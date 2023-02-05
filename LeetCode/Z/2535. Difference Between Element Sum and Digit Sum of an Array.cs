using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2535
    {
        public int DifferenceOfSum(int[] nums)
        {
            long sum = 0;
            long digits = 0;
            foreach (var n in nums)
            {
                sum += n;
                digits += GetDigits(n).Sum();
            }
            return (int)Math.Abs(sum - digits);
        }
        public static List<int> GetDigits(int source)
        {
            var digits = new List<int>();
            while (source > 0)
            {
                var digit = source % 10;
                digits.Add(digit);
                source = source / 10;
            }
            return digits;
        }
    }
}
