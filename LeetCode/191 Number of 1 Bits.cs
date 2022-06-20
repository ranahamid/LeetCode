using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _191_Number_of_1_Bits
    {
        /// <summary>
        /// Runtime: 32 ms, faster than 49.09% of C# online submissions for Number of 1 Bits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int HammingWeight(uint n = 00000000000000000000000000001011)
        {
            var counter = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    counter++;
                }
                n = n >> 1;
            }
            return counter;
        }
    }
}
