using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2729
    {
        public bool IsFascinating(int n)
        {
            var allDigits = new List<int>();
            allDigits.AddRange(GetDigits(n));
            allDigits.AddRange(GetDigits(n * 2));
            allDigits.AddRange(GetDigits(n * 3));
            var distinctDigits = allDigits.Where(x => x >= 1 && x <= 9).Distinct().ToList();
            if (distinctDigits.Count == 9 && allDigits.Count == 9)
                return true;
            return false;
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
