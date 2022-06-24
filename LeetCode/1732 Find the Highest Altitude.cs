using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1732_Find_the_Highest_Altitude
    {
        /// <summary>
        /// Runtime: 90 ms, faster than 84.13% of C# online submissions for Find the Highest Altitude.
        /// Memory Usage: 37.9 MB, less than 23.81% of C# online submissions for Find the Highest Altitude.
        /// </summary>
        /// <param name="gain"></param>
        /// <returns></returns>

        public static int LargestAltitude(int[] gain)
        {
            var start = 0;
            var max = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                var value = start + gain[i];
                max = Math.Max(max, value);
                start = value;
            }
            return max;
        }

    }
}
