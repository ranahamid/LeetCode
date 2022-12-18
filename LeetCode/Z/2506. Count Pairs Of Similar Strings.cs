using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2506
    {
        /// <summary>
        /// Runtime 104 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 49.2 MB Beats 100%
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public int SimilarPairs(string[] words)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var st = GetFrequency(word);
                dic.TryAdd(st, 0);
                dic[st]++;
            }
            int length = 0;
            foreach (var item in dic.Values)
            {
                if (item > 1)
                {
                    var k = item * (item - 1) / 2;
                    length += k;
                }
            }
            return length;
        }
        public string GetFrequency(string word)
        {
            var sb = new HashSet<char>();
            foreach (var ch in word)
            {
                sb.Add(ch);
            }
            var ar = sb.ToArray();
            Array.Sort(ar);
            var st = new string(ar);
            return st;
        }
    }
}
