using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _392
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 70.15% of C# online submissions for Is Subsequence.
        /// Memory Usage: 36.4 MB, less than 71.77% of C# online submissions for Is Subsequence.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            var tLength = t.Length;
            var i = 0;
            var counter = 0;
            while (counter < tLength)
            {
                if (s[i] == t[counter])
                {
                    i++;
                }
                counter++;
                if (i == s.Length)
                    return true;
            }
            return false;
        }
    }
}
