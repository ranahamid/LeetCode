using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _424
    {
        /// <summary>
        /// Runtime: 74 ms, faster than 92.63% of C# online submissions for Longest Repeating Character Replacement.
        /// Memory Usage: 36.2 MB, less than 68.25% of C# online submissions for Longest Repeating Character Replacement.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int CharacterReplacement(string s, int k)
        {
            var left = 0;
            var window = 0;
            var max = 0;
            var maxFreuency = 0;
            var frequency = new int[26];
            for (int right = 0; right < s.Length; right++)
            {
                frequency[s[right] - 'A']++;
                maxFreuency = Math.Max(maxFreuency, frequency[s[right] - 'A']);
                window = right - left + 1;
                if (window - maxFreuency > k)
                { 
                    frequency[s[left] - 'A']--;
                    left++;
                }
                else
                {
                    max = Math.Max(max, window);
                }
            }
            return max;
        }
    }
}
