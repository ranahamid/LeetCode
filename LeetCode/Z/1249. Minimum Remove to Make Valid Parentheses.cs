using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1249
    {
        /// <summary>
        /// Runtime: 110 ms, faster than 75.31% of C# online submissions for Minimum Remove to Make Valid Parentheses.
        /// Memory Usage: 47.9 MB, less than 5.00% of C# online submissions for Minimum Remove to Make Valid Parentheses.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="open"></param>
        /// <param name="close"></param>
        /// <returns></returns>
        public static StringBuilder RemoveString(string s, char open, char close)
        {
            var balance = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == open)
                {
                    balance++;
                }
                if (s[i] == close)
                {
                    if (balance == 0)
                        continue;
                    balance--;
                }
                sb.Append(s[i]);
            }
            return sb;
        }
        public string MinRemoveToMakeValid(string s)
        {
            var result = RemoveString(s, '(', ')');
            result = RemoveString(new string(result.ToString().Reverse().ToArray()), ')', '(');
            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
