using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1768_Merge_Strings_Alternately
    {
        /// <summary>
        /// Runtime: 76 ms, faster than 96.43% of C# online submissions for Merge Strings Alternately.
        /// Memory Usage: 37.1 MB, less than 9.38% of C# online submissions for Merge Strings Alternately.
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>

        public static string MergeAlternately(string word1, string word2)
        {
            var first = word1.ToCharArray();
            var second = word2.ToCharArray();
            var firstLen = first.Length;
            var secondLen = second.Length;

            var result = new char[firstLen + secondLen];
            var counter = 0;
            int i = 0, j = 0;

            while (firstLen != i || secondLen != j)
            {
                if (i != firstLen)
                {
                    result[counter++] = first[i++];
                }
                if (j != secondLen)
                {
                    result[counter++] = second[j++];
                }
            }
            return new string(result);
        }

    }
}
