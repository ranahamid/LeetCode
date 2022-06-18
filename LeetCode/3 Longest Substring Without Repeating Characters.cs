using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _3_Longest_Substring_Without_Repeating_Characters
    {
        /// <summary>
        /// Runtime: 112 ms, faster than 48.51% of C# online submissions for Longest Substring Without Repeating Characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LengthOfLongestSubstring(string s)
        {
            var chars = s.ToCharArray();
            int maxCount = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();
            int start = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (map.ContainsKey(chars[i]))
                {
                    var occuredInd = map[chars[i]] + 1;
                    start = Math.Max(start, occuredInd);
                }
                maxCount = Math.Max(maxCount, i - start + 1);
                map[chars[i]] = i;
            }
            return maxCount;
        }
    }
}
