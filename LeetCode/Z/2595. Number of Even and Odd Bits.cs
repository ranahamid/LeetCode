using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2595
    {
        public int[] EvenOddBit(int n)
        {
            int[] result = new int[2];
            for (int i = 0; i < 32; i++)
            {
                if ((n & (1 << i)) != 0)
                {
                    result[i % 2]++;
                }
            }
            return result;
        }
    }
}
