using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1078
    {
        /// <summary>
        /// Runtime: 229 ms, faster than 21.62% of C# online submissions for Occurrences After Bigram.
        /// Memory Usage: 41.3 MB, less than 81.08% of C# online submissions for Occurrences After Bigram.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static string[] FindOcurrences(string text, string first, string second)
        {
            var resut = new List<string>();
            var words = text.Split(' ');
            if (words.Length > 2)
            {
                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (words[i] == first && words[i + 1] == second)
                    {
                        if (i + 2 < words.Length)
                        {
                            resut.Add(words[i + 2]);
                        }
                    }
                }
            }
            return resut.ToArray();
        }
    }
}
