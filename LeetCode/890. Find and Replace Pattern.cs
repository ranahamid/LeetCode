using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _890
    {
        /// <summary>
        /// Runtime: 175 ms, faster than 70.00% of C# online submissions for Find and Replace Pattern.
        /// Memory Usage: 43.4 MB, less than 42.00% of C# online submissions for Find and Replace Pattern.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var result = new List<string>();
            foreach (var word in words)
                if (IsWordMatch(word, pattern))
                {
                    result.Add(word);
                }
            return result;
        }
        public static bool IsWordMatch(string word, string pattern)
        {
            Dictionary<char, char> map1 = new Dictionary<char, char>();
            Dictionary<char, char> map2 = new Dictionary<char, char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (!map1.ContainsKey(word[i]))
                {
                    map1[word[i]] = pattern[i];
                }
                if (!map2.ContainsKey(pattern[i]))
                {
                    map2[pattern[i]] = word[i];
                }

                if (map1[word[i]] != pattern[i])
                    return false;
                if (map2[pattern[i]] != word[i])
                    return false;
            }
            return true;
        }
    }
}
