using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1017
    {
        public static string BaseNeg2(int n)
        {
            if (n == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            while (n != 0)
            {
                var temp = n & 1;
                sb.Append(temp);
                n = -(n >> 1);
            }
            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
/*
 A number n and a negative base negBase is given to us, we need to represent n in that negative base. Negative base works similar to positive base. For example in base 2 we multiply bits to 1, 2, 4, 8 and so on to get actual number in decimal.
In case of base -2 we need to multiply bits with 1, -2, 4, -8 and so on to get number in decimal.

Input  : n = 13, negBase = -2
Output : 11101
1*(16) + 1*(-8) + 1*(4) + 0*(-2) + 1*(1)  = 13
 */