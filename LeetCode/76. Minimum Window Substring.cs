using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _76
    {
        /// <summary>
        /// Runtime 85 ms Beats 97.53% Memory 39.6 MB Beats 23.61%
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public string MinWindow(string s, string t)
        {
            var map = new Dictionary<char, int>();
            foreach (var ch in t)
            {
                map.TryAdd(ch, 0);
                map[ch]++;
            }
            int minLen = Int32.MaxValue, minStart = 0, i = 0, j = 0, remaining = t.Length;
            while (j < s.Length)
            {
                var ch = s[j];
                j++;
                if (map.ContainsKey(ch))
                {
                    map[ch]--;
                    if (map[ch] >= 0)
                    {
                        remaining--;
                    }
                }
                while (remaining == 0)
                {
                    if (j - i < minLen)
                    {
                        minLen = j - i;
                        minStart = i;
                    }

                    ch = s[i];
                    i++;
                    if (map.ContainsKey(ch))
                    {
                        map[ch]++;
                        if (map[ch] > 0)
                        {
                            remaining++;
                        }
                    }
                }
            }
            if (minLen == Int32.MaxValue)
                return "";
            return s.Substring(minStart, minLen);
        }
    }
}
