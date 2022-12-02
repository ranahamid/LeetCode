using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1657
    {
        /// <summary>
        /// Runtime 156 ms Beats 60% Memory 48.8 MB Beats 20%
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            var dic1 = new Dictionary<char, int>();
            var dic2 = new Dictionary<char, int>();
            foreach (var ch in word1)
            {
                dic1.TryAdd(ch, 0);
                dic1[ch]++;
            }
            foreach (var ch in word2)
            {
                dic2.TryAdd(ch, 0);
                dic2[ch]++;
            }
            var chars1 = dic1.Select(x => x.Key).ToList();
            var chars2 = dic2.Select(x => x.Key).ToList();
            chars1.Sort();
            chars2.Sort();
            if (!chars1.SequenceEqual(chars2))
                return false;

            var val1 = dic1.Select(x => x.Value).ToList();
            var val2 = dic2.Select(x => x.Value).ToList();
            val1.Sort();
            val2.Sort();
            if (!val1.SequenceEqual(val2))
                return false;
            return true;
        }
    }
}
