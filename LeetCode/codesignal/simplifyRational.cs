using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class simplifyRational
    {
        public int[] solution(int numerator, int denominator)
        {
            if (denominator < 0)
            {
                numerator = numerator * -1;
                denominator = denominator * -1;
            }
            var isMinuse = false;
            if (numerator < 0)
            {
                isMinuse = true;
                numerator = numerator * -1;
            }
            var result = new int[2];
            var gcdVal = GCD(numerator, denominator);
            result[0] = numerator / gcdVal;
            result[1] = denominator / gcdVal;
            if (isMinuse)
                result[0] = result[0] * -1;
            return result;
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
