using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _408
    {
        /// <summary>
        /// Runtime: 97 ms, faster than 53.12% of C# online submissions for Valid Word Abbreviation.
        /// Memory Usage: 37.5 MB, less than 65.62% of C# online submissions for Valid Word Abbreviation.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="abbr"></param>
        /// <returns></returns>
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            int i = 0;
            int j = 0;
            var wordLength = word.Length;
            var abLength = abbr.Length;
            while (i < wordLength && j < abLength)
            {
                var num = 0;
                if (char.IsDigit(abbr[j]))
                {
                    if (abbr[j] == '0')
                    {
                        return false;
                    }
                    while (j < abLength && char.IsDigit(abbr[j]))
                    {
                        num = num * 10 + Int32.Parse(abbr[j].ToString());
                        j++;
                    }
                    i += num;
                    if (i > wordLength)
                        return false;
                    if (j > abLength)
                        return false;
                }
                else
                {
                    if (word[i] == abbr[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (j != abLength)
                return false;
            if (i != wordLength)
                return false;
            return true;
        }
    }
}
