using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _340
    {
        /// <summary>
        /// Runtime: 96 ms, faster than 72.41% of C# online submissions for Longest Substring with At Most K Distinct Characters.
        /// Memory Usage: 36.4 MB, less than 73.79% of C# online submissions for Longest Substring with At Most K Distinct Characters.
        /// </summary>
        /// <param name="fruits"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LengthOfLongestSubstringKDistinct(string fruits, int k)
        {
            var dict = new Dictionary<char, int>();
            int i = 0, j;
            for (j = 0; j < fruits.Length; j++)
            {
                if (dict.ContainsKey(fruits[j]))
                    dict[fruits[j]]++;
                else
                    dict[fruits[j]] = 1;
                if (dict.Count > k)
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
