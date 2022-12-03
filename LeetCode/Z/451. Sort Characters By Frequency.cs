using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _451
    {
        public string FrequencySort(string s)
        {
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                dic.TryAdd(ch, 0);
                dic[ch]++;
            }
            var list = dic.OrderByDescending(x => x.Value).ToList();
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                for (int j = 0; j < item.Value; j++)
                    sb.Append(item.Key);
            }
            return sb.ToString();
        }
        /// <summary>
        /// Runtime: 128 ms, faster than 61.49% of C# online submissions for Sort Characters By Frequency.
        ///Memory Usage: 39 MB, less than 76.70% of C# online submissions for Sort Characters By Frequency.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string FrequencySort_1(string s)
        {
            var set = GetFrequencyString(s);
            var data = set.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            var result = new StringBuilder();
            foreach (var item in data)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    result.Append(item.Key);
                }
            }
            return result.ToString();
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
    }
}
