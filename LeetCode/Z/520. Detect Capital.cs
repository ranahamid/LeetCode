using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _520
    {
        /// <summary>
        /// Runtime 82 ms Beats 79.17% Memory 39.3 MB Beats 14.17%
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse(string word)
        {
            if (word.ToLower() == word)
                return true;
            if (word.ToUpper() == word)
                return true;

            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {


                    if (word[i] == char.ToUpper(word[i]))
                        continue;
                    else
                        return false;
                }
                else
                {
                    if (word[i] == char.ToLower(word[i]))
                        continue;
                    else
                        return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Runtime: 125 ms, faster than 30.68% of C# online submissions for Detect Capital.
        /// Memory Usage: 37.4 MB, less than 46.59% of C# online submissions for Detect Capital.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse_1(string word)
        {
            if (word == word.ToLower() || word == word.ToUpper() || word == TitleCase(word))
            {
                return true;
            }
            return false;
        }
        public static string TitleCase(string word)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(char.ToUpper(word[i]));
                }
                else
                {
                    sb.Append(char.ToLower(word[i]));
                }
            }
            return sb.ToString();
        }
    }
}
