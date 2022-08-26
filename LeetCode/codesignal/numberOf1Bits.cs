using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class numberOf1Bits
    {
        int solution(int n)
        {
            int res = 0;
            while (n != 0)
            {
                n &= n - 1;
                res++;
            }
            return res;
        }

    }
}
