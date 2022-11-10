using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _748
    {
        /// <summary>
        /// Runtime: 143 ms, faster than 81.58% of C# online submissions for Shortest Completing Word.
        /// Memory Usage: 42.3 MB, less than 52.63% of C# online submissions for Shortest Completing Word.
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (char.IsLetter(licensePlate[i]))
                    sb.Append(licensePlate[i].ToString());
            }
            var sf = GetFrequencyString(sb.ToString());
            var result = new SortedDictionary<int, string>();
            foreach (var word in words)
            {
                var wf = GetFrequencyString(word);
                //valid
                if (IsValid(sf, wf))
                {
                    if (!result.ContainsKey(word.Length))
                        result.Add(word.Length, word);
                }
            }
            return result.FirstOrDefault().Value;
        }
        public bool IsValid(Dictionary<char, int> s, Dictionary<char, int> w)
        {
            foreach (var item in s)
            {
                if (w.ContainsKey(item.Key))
                {
                    if (item.Value > w[item.Key])
                        return false;
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
                var ch = char.ToUpper(s[index]);
                if (map.ContainsKey(ch))
                {
                    map[ch]++;
                }
                else
                {
                    map[ch] = 1;
                }
            }
            return map;
        }
    }
}
