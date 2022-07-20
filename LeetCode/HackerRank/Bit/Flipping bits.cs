using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Bit
{
    internal class Flipping_bits
    {
        public static long flippingBits(long n)
        {
            var binary = Convert.ToString(n, 2).PadLeft(32, '0');
            StringBuilder sb = new StringBuilder(binary);
            for (int i = 0; i < binary.Length; i++)
            {
                sb[i] = sb[i] == '0' ? '1' : '0';
            }
            long l = Convert.ToInt64(sb.ToString(), 2);
            return l;
        }
    }
}
