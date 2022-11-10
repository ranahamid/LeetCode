using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2457
    {
        public long MakeIntegerBeautiful(long n, int target)
        {
            long m = n;
            long baseDigit = 1;
            while (GetDigitSum(n) > target)
            {
                n = n / 10 + 1; //19= 2= > 0+1=1
                baseDigit *= 10; // 1*10=10 => 10*10=100
            }
            return n * baseDigit - m;
        }

        public static int GetDigitSum(long source)
        {
            long answer = 0;
            while (source > 0)
            {
                var digit = source % 10;
                answer += digit;
                source = source / 10;
            }
            return (int)answer;
        }
    }
}
