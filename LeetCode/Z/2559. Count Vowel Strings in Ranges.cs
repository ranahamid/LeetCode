using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2559
    {
        /// <summary>
        /// Runtime: 302 ms, faster than 100.00% of C# online submissions for Count Vowel Strings in Ranges.
        /// Memory Usage: 66.3 MB, less than 100.00% of C# online submissions for Count Vowel Strings in Ranges.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int[] VowelStrings(string[] words, int[][] queries)
        {
            var vowels = new bool[words.Length];
            var chars = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var prefixSum = new int[words.Length + 1];
            prefixSum[0] = 0;
            int i = 0;
            for (i = 0; i < words.Length; i++)
            {
                var length = words[i].Length;
                if (i != 0)
                    prefixSum[i + 1] = prefixSum[i];

                if (chars.Contains(words[i][0]) && chars.Contains(words[i][length - 1]))
                {
                    vowels[i] = true;
                    if (i == 0)
                        prefixSum[i + 1] = 1;
                    else
                        prefixSum[i + 1] = prefixSum[i] + 1;
                }
            }
            var result = new int[queries.Length];
            i = 0;
            foreach (var q in queries)
            {
                int val = prefixSum[q[1] + 1] - prefixSum[q[0]];
                result[i++] = val;
            }

            return result;
        }
    }
}
