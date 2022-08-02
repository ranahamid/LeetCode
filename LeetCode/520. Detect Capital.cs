using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _520
    {
        /// <summary>
        /// Runtime: 125 ms, faster than 30.68% of C# online submissions for Detect Capital.
        /// Memory Usage: 37.4 MB, less than 46.59% of C# online submissions for Detect Capital.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse(string word)
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
