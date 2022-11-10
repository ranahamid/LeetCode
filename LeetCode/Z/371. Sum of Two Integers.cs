using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _371
    {
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                var temp = a & b;
                var dub = temp << 1;
                a = a ^ b;
                b = dub;
            }
            return a;
        }
    }
}
