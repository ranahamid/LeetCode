using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _438
    {
        #region solution
        /// <summary>
        /// Runtime: 257 ms, faster than 33.62% of C# online submissions for Find All Anagrams in a String.
        /// Memory Usage: 45.4 MB, less than 85.06% of C# online submissions for Find All Anagrams in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            var sLen = s.Length;
            var pLen = p.Length;
            if (pLen > sLen)
                return new List<int>();
            var pF = GetFrequencyString(p);
            Dictionary<char, int> sF = new Dictionary<char, int>();
            for (int i = 0; i < sLen; i++)
            {
                if (sF.ContainsKey(s[i]))
                {
                    sF[s[i]]++;
                }
                else
                {
                    sF[s[i]] = 1;
                }
                if (i >= pLen)
                {
                    var ch = s[i - pLen];
                    if (sF[ch] == 1)
                    {
                        sF.Remove(ch);
                    }
                    else
                    {
                        sF[ch]--;
                    }
                }
                //comparison
                if (IsSameDictionary(pF, sF))
                    result.Add(i - pLen + 1);
            }
            return result;
        }

        public static Dictionary<char, int> GetFrequencyString(string s)
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

        public static bool IsSameDictionary(Dictionary<char, int> a, Dictionary<char, int> b)
        {
            foreach (var item in a)
            {
                if (b.ContainsKey(item.Key))
                {
                    var bVal = b[item.Key];
                    if (bVal != item.Value)
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
        #endregion
        #region TLE
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            var pChar = p.ToCharArray();
            Array.Sort(pChar);
            p = new string(pChar);
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                var subStr = s.Substring(i, p.Length);
                Array.Sort(subStr.ToArray());
                if (p == new String(subStr))
                    result.Add(i);
            }
            return result;
        }
        #endregion

    }
}
