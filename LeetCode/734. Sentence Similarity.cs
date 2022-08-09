using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _734
    {
        /// <summary>
        /// Runtime: 122 ms, faster than 87.50% of C# online submissions for Sentence Similarity.
        /// Memory Usage: 41.9 MB, less than 8.33% of C# online submissions for Sentence Similarity.
        /// </summary>
        /// <param name="sentence1"></param>
        /// <param name="sentence2"></param>
        /// <param name="similarPairs"></param>
        /// <returns></returns>
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            var s1Len = sentence1.Length;
            var s2Len = sentence2.Length;
            if (s1Len != s2Len)
                return false;
            for (int i = 0; i < s1Len; i++)
            {
                if (sentence1[i] == sentence2[i])
                    continue;
                var isMatch = false;
                var listItems = similarPairs.Where(x => x[0] == sentence1[i] || x[1] == sentence1[i]).ToList();
                foreach (var s1 in listItems)
                {
                    if (s1 != null && (s1[0] == sentence2[i] || s1[1] == sentence2[i]))
                    {
                        isMatch = true;
                        break;
                    }
                }
                if (isMatch == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
