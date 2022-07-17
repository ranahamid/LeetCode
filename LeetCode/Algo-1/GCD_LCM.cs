using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class GCD_LCM
    {
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

        public static int LCM(int a, int b)
        {
            return (a / GCD(a, b)) * b;
        }
    }
}
