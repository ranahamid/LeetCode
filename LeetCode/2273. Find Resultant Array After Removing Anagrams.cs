using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2273
    {
        /// <summary>
        /// Runtime: 274 ms, faster than 25.53% of C# online submissions for Find Resultant Array After Removing Anagrams.
        ///Memory Usage: 47 MB, less than 8.51% of C# online submissions for Find Resultant Array After Removing Anagrams.
    /// </summary>
    /// <param name="words"></param>
    /// <returns></returns>
        public IList<string> RemoveAnagrams(string[] words)
        {

            var result = new List<string>(words);
            while (true)
            {
                var isFound = false;
                for (int i = 0; i < result.Count - 1; i++)
                {
                    var first = GetFrequencyString(result[i]);
                    int j = 0;
                    for (j = i + 1; j <= i + 1; j++)
                    {
                        var sec = GetFrequencyString(result[j]);
                        if (IsValid(first, sec) && IsValid(sec, first))
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if (isFound)
                    {
                        result.RemoveAt(j);
                        break;
                    }
                }
                if (!isFound)
                    break;
            }
            return result;
        }
        public bool IsValid(Dictionary<char, int> first, Dictionary<char, int> sec)
        {
            foreach (var item in first)
            {
                if (sec.ContainsKey(item.Key))
                {
                    if (sec[item.Key] != item.Value)
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
        public static Dictionary<char, int> GetFrequencyString(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int index = 0; index < s.Length; index++)
            {
                if (map.ContainsKey(s[index]))
                {
                    map[s[index]]++;
                }
                else
                {
                    map[s[index]] = 1;
                }
            }
            return map;
        }
    }
}
