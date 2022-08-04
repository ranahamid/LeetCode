using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LeetCode
{
    internal class _10
    {
        /// <summary>
        /// Runtime: 134 ms, faster than 54.33% of C# online submissions for Regular Expression Matching.
        /// Memory Usage: 39.9 MB, less than 12.98% of C# online submissions for Regular Expression Matching.
        /// </summary>
        public class Solution
        {
            /// <summary>
            /// ^ represents the start of the current line in multi-line mode, otherwise the start of the string
            ///$ represents the end of the current line in multi-line mode, otherwise the end of the string
            /// </summary>
            /// <param name="s"></param>
            /// <param name="p"></param>
            /// <returns></returns>
            public bool IsMatch(string s, string p)
            {
                return Regex.IsMatch(s, "^" + p + "$");
            }
        }
    }
}

