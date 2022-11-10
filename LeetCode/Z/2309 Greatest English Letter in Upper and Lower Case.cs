using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2309_Greatest_English_Letter_in_Upper_and_Lower_Case
    {
        /// <summary>
        /// Runtime: 94 ms, faster than 91.91% of C# online submissions for Greatest English Letter in Upper and Lower Case.
        /// Memory Usage: 36.4 MB, less than 67.23% of C# online submissions for Greatest English Letter in Upper and Lower Case.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GreatestLetter(string s)
        {
            int[] capital = new int[26];
            int[] small = new int[26];
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    var num = c - 65;
                    capital[num]++;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    var num = c - 97;
                    small[num]++;
                }
            }
            for (int i = 25; i >= 0; i--)
            {
                if (capital[i] > 0 && small[i] > 0)
                {
                    char res = (char)(65 + i);
                    return res.ToString();
                }
            }
            return "";
        }
    }
}
