using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _2268
    {
        /// <summary>
        /// Runtime 105 ms Beats 74.16% Memory 39.2 MB Beats 53.93%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinimumKeypresses(string s)
        {
            var freq = new int[26];
            foreach (var ch in s)
            {
                freq[ch - 'a']++;
            }
            Array.Sort(freq, (a, b) => b.CompareTo(a));
            int result = 0, counter = 0;
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    result += freq[i] * (counter / 9 + 1);
                    counter++;
                }
            }
            return result;

        }
    }
}
