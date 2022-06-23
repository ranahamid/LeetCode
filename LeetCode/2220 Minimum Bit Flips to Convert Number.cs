using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2220_Minimum_Bit_Flips_to_Convert_Number
    {
        /// <summary>
        /// Runtime: 63 ms, faster than 5.21% of C# online submissions for Minimum Bit Flips to Convert Number.
        /// Memory Usage: 25.5 MB, less than 34.37% of C# online submissions for Minimum Bit Flips to Convert Number.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="goal"></param>
        /// <returns></returns>

        public static int MinBitFlips(int start, int goal)
        {
            var input = Convert.ToString(start, 2).PadLeft(32, '0');
            var output = Convert.ToString(goal, 2).PadLeft(32, '0');
            var counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != output[i])
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Runtime: 23 ms, faster than 89.58% of C# online submissions for Minimum Bit Flips to Convert Number.
        /// Memory Usage: 26.7 MB, less than 7.29% of C# online submissions for Minimum Bit Flips to Convert Number.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="goal"></param>
        /// <returns></returns>

        public static int MinBitFlips_2(int start, int goal)
        {
            var output = start ^ goal;
            var counter = 0;
            while (output != 0)
            {
                counter++;
                output = output & output - 1;
            }
            return counter;
        }

    }
}
