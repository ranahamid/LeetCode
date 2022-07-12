using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _242
    {
        /// <summary>
        /// Runtime: 72 ms, faster than 99.21% of C# online submissions for Valid Anagram.
        /// Memory Usage: 39.9 MB, less than 18.80% of C# online submissions for Valid Anagram.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            var sF = GetFrequency(s);
            var tF = GetFrequency(t);
            foreach (var item in tF)
            {
                var key = item.Key;
                var freq = item.Value;
                if (sF.ContainsKey(key))
                {
                    var val = sF[key];
                    if (val < freq)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            //first
            foreach (var item in sF)
            {
                var key = item.Key;
                var freq = item.Value;
                if (tF.ContainsKey(key))
                {
                    var val = tF[key];
                    if (val < freq)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;

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
