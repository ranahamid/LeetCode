using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _459
    {
        public bool RepeatedSubstringPattern(string s)
        {
            return ((s + s).Substring(1, (s.Length * 2) - 2).Contains(s));
        }
        /// <summary>
        /// Runtime: 82 ms, faster than 97.45% of C# online submissions for Repeated Substring Pattern.
        /// Memory Usage: 50.5 MB, less than 6.93% of C# online submissions for Repeated Substring Pattern.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RepeatedSubstringPattern_1(string s)
        {
            var mergeWord = s + s;
            var sub = mergeWord.Substring(1, mergeWord.Length - 2);
            return sub.Contains(s);
        }
    }
}
