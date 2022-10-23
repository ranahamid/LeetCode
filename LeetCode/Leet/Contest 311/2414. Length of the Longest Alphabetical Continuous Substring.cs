using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_311
{
    internal class _2414
    {
        /// <summary>
        /// Runtime: 100 ms, faster than 100.00% of C# online submissions for Length of the Longest Alphabetical Continuous Substring.
        /// Memory Usage: 40.3 MB, less than 100.00% of C# online submissions for Length of the Longest Alphabetical Continuous Substring.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LongestContinuousSubstring(string s)
        {
            int maxValue = 1, result = 1;
            for (int index = 1; index < s.Length; index++)
            {
                if (s[index] == s[index - 1] + 1)
                {
                    result++;
                    maxValue = Math.Max(result, maxValue);
                }
                else
                {
                    //reset
                    result = 1;
                }
            }
            maxValue = Math.Max(maxValue, result);
            return maxValue;
        }
    }
}
