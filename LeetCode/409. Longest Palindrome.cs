using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _409
    {    /// <summary>
         /// Runtime: 103 ms, faster than 38.66% of C# online submissions for Longest Palindrome.
         /// Memory Usage: 34.8 MB, less than 85.46% of C# online submissions for Longest Palindrome.
         /// </summary>
         /// <param name="s"></param>
         /// <returns></returns>
        public int LongestPalindrome(string s)
        {
            var result = 0;
            var freq = GetFrequency(s);
            foreach (var p in freq)
            {
                var val = p.Value;
                result += val / 2 * 2;
                if (result % 2 == 0 && val % 2 == 1)
                {
                    result++;
                }
            }
            return result;
        }
        public static Dictionary<char, int> GetFrequency(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            return map;
        }
    }
}
