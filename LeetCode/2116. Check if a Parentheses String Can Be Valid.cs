using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2116
    {
        /// <summary>
        /// Runtime: 104 ms, faster than 93.75% of C# online submissions for Check if a Parentheses String Can Be Valid.
        /// Memory Usage: 56.8 MB, less than 6.25% of C# online submissions for Check if a Parentheses String Can Be Valid.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="locked"></param>
        /// <returns></returns>
        public bool CanBeValid(string s, string locked)
        {
            int total = 0, open = 0, close = 0;
            if (s.Length % 2 == 1)
                return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (locked[i] == '0')
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
                if (locked[i] == '0')
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
