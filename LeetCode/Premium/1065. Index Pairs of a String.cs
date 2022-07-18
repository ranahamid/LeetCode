using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1065
    {
        /// <summary>
        /// Runtime: 211 ms, faster than 50.00% of C# online submissions for Index Pairs of a String.
        /// Memory Usage: 43.6 MB, less than 50.00% of C# online submissions for Index Pairs of a String.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public int[][] IndexPairs(string text, string[] words)
        {

            var result = new List<int[]>();
            foreach (var word in words)
            {
                var indexes = GetWordIndexes(text, word);
                foreach (var index in indexes)
                {
                    if (index >= 0)
                    {
                        var data = new int[2];
                        data[0] = index;
                        data[1] = index + word.Length - 1;
                        result.Add(data);
                    }
                }
            }
            result = result.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
            return result.ToArray();
        }
        public IEnumerable<int> GetWordIndexes(string text, string word)
        {
            int wordLength = word.Length;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text.Length - wordLength >= i) && text.Substring(i, wordLength) == word)
                    yield return i;
            }
        }
    }
}
