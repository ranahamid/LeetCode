using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Bit
{
    internal class AND_Product
    {
        public static long andProduct(long a, long b)
        {
            if (a == 0)
                return 0;
            int counter = 0;
            while (a != b)
            {
                counter++;
                a >>= 1;
                b >>= 1;
            }
            var andSum = a << counter;
            return andSum;
        }
    }
}
