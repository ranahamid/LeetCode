using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class bitsToFloat
    {
        double solution(int bits)
        {
            double intp = bits >> 16;
            double frap = (double)(bits & 0xFFFF);
            while (frap >= 1.0)
            {
                frap /= 10.0;
            }
            return intp + frap;
        }

    }
}
