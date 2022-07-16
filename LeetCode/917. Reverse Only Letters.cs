using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _917
    {
        /// <summary>
        /// Runtime: 135 ms, faster than 25.00% of C# online submissions for Reverse Only Letters.
        /// Memory Usage: 35.4 MB, less than 94.00% of C# online submissions for Reverse Only Letters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseOnlyLetters(string s)
        {
            var length = s.Length;
            var start = 0;
            var end = length - 1;
            StringBuilder sb = new StringBuilder(s);

            while (start < end)
            {
                if (!char.IsLetter(sb[start]))
                {
                    start++;
                }
                if (!char.IsLetter(sb[end]))
                {
                    end--;
                }
                if (char.IsLetter(s[start]) && char.IsLetter(s[end]))
                {
                    (sb[start], sb[end]) = (sb[end], sb[start]);
                    start++;
                    end--;
                }
            }
            return sb.ToString();
        }
    }
}
