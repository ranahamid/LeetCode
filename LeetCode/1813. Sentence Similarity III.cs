using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1813
    {
        /// <summary>
        /// Runtime: 73 ms, faster than 100.00% of C# online submissions for Sentence Similarity III.
        /// Memory Usage: 38.5 MB, less than 7.14% of C# online submissions for Sentence Similarity III.
        /// </summary>
        /// <param name="sentence1"></param>
        /// <param name="sentence2"></param>
        /// <returns></returns>
        public bool AreSentencesSimilar(string sentence1, string sentence2)
        {
            var s1 = sentence1.Split(' ', options: StringSplitOptions.RemoveEmptyEntries);
            var s2 = sentence2.Split(' ', options: StringSplitOptions.RemoveEmptyEntries);

            var n1 = s1.Length; //less
            var n2 = s2.Length;
            if (n1 > n2)
                return (AreSentencesSimilar(sentence2, sentence1));

            int i = 0;
            while (i < n1 && s1[i] == s2[i])
            {
                i++;
            }
            while (i < n1 && s1[i] == s2[n2 - n1 + i])
            {
                i++;
            }
            return i == n1;
        }
    }
}
