using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1763
    {
        /// <summary>
        /// Runtime: 77 ms, faster than 100.00% of C# online submissions for Longest Nice Substring.
        /// Memory Usage: 36.7 MB, less than 81.08% of C# online submissions for Longest Nice Substring.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestNiceSubstring(string s)
        {
            var result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int xor1 = 0, xor2 = 0;
                for (int j = i; j < s.Length; j++)
                {
                    if (s[j] >= 'a' && s[j] <= 'z')
                        xor1 |= 1 << s[j];
                    else
                        xor2 |= 1 << s[j];

                    if ((xor1 ^ xor2) == 0 && (j - i + 1 > result.Length))
                        result = s.Substring(i, j - i + 1);
                }
            }
            return result;
        }
    }
}
