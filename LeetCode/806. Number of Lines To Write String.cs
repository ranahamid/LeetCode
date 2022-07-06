using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _806
    {
        /// <summary>
        /// Runtime: 229 ms, faster than 40.00% of C# online submissions for Number of Lines To Write String.
        /// Memory Usage: 40.9 MB, less than 85.71% of C# online submissions for Number of Lines To Write String.
        /// </summary>
        /// <param name="widths"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int[] NumberOfLines(int[] widths, string s)
        {
            var lines = 0;
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var currentpixel = widths[s[i] - 97];
                sum = sum + currentpixel;
                if (sum > 100)
                {
                    lines++;
                    sum = currentpixel;
                }
            }
            int[] result = new int[2] { lines + 1, sum };
            return result;
        }

    }
}
