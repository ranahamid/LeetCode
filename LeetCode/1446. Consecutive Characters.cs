using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1446
    {
        /// <summary>
        /// Runtime: 52 ms, faster than 100.00% of C# online submissions for Consecutive Characters.
        /// Memory Usage: 37.1 MB, less than 8.20% of C# online submissions for Consecutive Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxPower(string s)
        {
            var max = 0;
            var counter = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    counter++;
                }
                else
                {
                    max = Math.Max(counter + 1, max);
                    counter = 0;
                }
            }

            max = Math.Max(counter + 1, max);
            return max;
        }

    }
}
