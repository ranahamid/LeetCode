using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _190_Reverse_Bits
    {

        /// <summary>
        /// Runtime: 36 ms, faster than 44.88% of C# online submissions for Reverse Bits.
        ///Memory Usage: 22.8 MB, less than 53.63% of C# online submissions for Reverse Bits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                if ((n & 1) == 1)
                    result++;
                n >>= 1;
            }
            return result;
        }

        /// <summary>
        /// Runtime: 49 ms, faster than 11.55% of C# online submissions for Reverse Bits.
        /// Memory Usage: 23.1 MB, less than 28.71% of C# online submissions for Reverse Bits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static uint reverseBits_2(uint n)
        {
            var number = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            Array.Reverse(number);
            var st = new string(number);
            var result = Convert.ToInt32(st, 2);
            return (uint)result;
        }

    }
}
