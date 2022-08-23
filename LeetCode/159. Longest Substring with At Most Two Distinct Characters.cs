using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _159
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 95.83% of C# online submissions for Longest Substring with At Most Two Distinct Characters.
        /// Memory Usage: 41.1 MB, less than 16.67% of C# online submissions for Longest Substring with At Most Two Distinct Characters.
        /// </summary>
        /// <param name="fruits"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstringTwoDistinct(string fruits)
        {
            var dict = new Dictionary<char, int>();
            int i = 0, j;
            for (j = 0; j < fruits.Length; j++)
            {
                if (dict.ContainsKey(fruits[j]))
                    dict[fruits[j]]++;
                else
                    dict[fruits[j]] = 1;
                if (dict.Count > 2)
                {
                    dict[fruits[i]]--;
                    if (dict[fruits[i]] == 0)
                        dict.Remove(fruits[i]);
                    i++;
                }
            }
            return j - i;
        }
    }
}
