using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1816_Truncate_Sentence
    {
        /// <summary>
        /// Runtime: 83 ms, faster than 87.57% of C# online submissions for Truncate Sentence.
        /// Memory Usage: 37.6 MB, less than 14.79% of C# online submissions for Truncate Sentence.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public static string TruncateSentence(string s, int k)
        {
            var data = s.Split(' ');
            var result = new List<string>();
            for (int i = 0; i < k; i++)
            {
                result.Add(data[i]);
            }
            var res = string.Join(" ", result);
            return res;
        }

    }
}
