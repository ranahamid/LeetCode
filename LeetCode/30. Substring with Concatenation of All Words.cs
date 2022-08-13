using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _30
    {
        /// <summary>
        /// Runtime: 408 ms, faster than 63.25% of C# online submissions for Substring with Concatenation of All Words.
        /// Memory Usage: 46.3 MB, less than 56.22% of C# online submissions for Substring with Concatenation of All Words.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="s"></param>
        /// <param name="wordCount"></param>
        /// <param name="sLen"></param>
        /// <param name="k"></param>
        /// <param name="wordLen"></param>
        /// <param name="totalSubLen"></param>
        /// <returns></returns>
        public static bool CheckSub(int i, string s, Dictionary<string, int> wordCount, int sLen, int k, int wordLen, int totalSubLen)
        {
            var remaing = new Dictionary<string, int>(wordCount);
            var counter = 0;
            for (int j = i; j < i + totalSubLen; j = j + wordLen)
            {
                var substr = s.Substring(j, wordLen);
                if (remaing.ContainsKey(substr))
                {
                    if (remaing[substr] > 0)
                    {
                        counter++;
                        remaing[substr]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            if (counter == k)
                return true;
            return false;
        }
        public IList<int> FindSubstring(string s, string[] words)
        {
            int sLen;
            int k;
            int wordLen;
            int totalSubLen = 0;

            sLen = s.Length;
            k = words.Length;
            wordLen = words[0].Length;
            totalSubLen = k * wordLen;
            var result = new List<int>();
            var wordCount = GetFrequencyString(words);
            for (int i = 0; i < sLen - totalSubLen + 1; i++)
            {
                if (CheckSub(i, s, wordCount, sLen, k, wordLen, totalSubLen))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static Dictionary<string, int> GetFrequencyString(string[] s)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
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
