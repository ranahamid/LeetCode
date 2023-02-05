using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2553
    {
        /// <summary>
        /// Runtime: 145 ms, faster than 100.00% of C# online submissions for Separate the Digits in an Array.
        ///  Memory Usage: 46.3 MB, less than 100.00% of C# online submissions for Separate the Digits in an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SeparateDigits(int[] nums)
        {
            var digits = new List<int>();
            foreach (var n in nums)
            {
                var dig = GetDigits(n);
                dig.Reverse();
                digits.AddRange(dig);
            }
            return digits.ToArray();
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
