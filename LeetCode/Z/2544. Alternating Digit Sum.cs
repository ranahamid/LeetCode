using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2544
    {
        public int AlternateDigitSum(int n)
        {
            var digits = GetDigits(n);
            digits.Reverse();
            var flag = true;
            int sum = 0;
            foreach (var digit in digits)
            {
                sum += flag ? digit : -digit;
                flag = !flag;
            }
            return sum;
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
