using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class shapeArea
    {
        int solution(int n)
        {
            return P(n);
        }
        public static int P(int n)
        {
            if (n == 1)
                return 1;
            return P(n - 1) +4*(n-1);
        }
    }
}
