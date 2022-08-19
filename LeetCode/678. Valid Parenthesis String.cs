using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _678
    {
        /// <summary>
        /// Runtime: 84 ms, faster than 82.31% of C# online submissions for Valid Parenthesis String.
        /// Memory Usage: 36.4 MB, less than 63.08% of C# online submissions for Valid Parenthesis String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckValidString(string s)
        {
            int total = 0, open = 0, close = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                    total++;
                else if (s[i] == '(')
                    open++;
                else if (s[i] == ')')
                    close++;
                if (total + open - close < 0)
                    return false;
            }
            total = 0; open = 0; close = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '*')
                    total++;
                else if (s[i] == '(')
                    open++;
                else if (s[i] == ')')
                    close++;
                if (total + close - open < 0)
                    return false;
            }
            return true;
        }
    }
}
