using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1085
    {
        public int SumOfDigits(int[] nums)
        {
            Array.Sort(nums);
            var digits = GetDigitsSum(nums[0]);
            if (digits % 2 == 1)
            {
                return 0;
            }
            return 1;
        }
        public static int GetDigitsSum(int source)
        {
            int sum = 0;
            while (source > 0)
            {
                var digit = source % 10;
                sum += digit;
                source = source / 10;
            }
            return sum;
        }
    }
}
