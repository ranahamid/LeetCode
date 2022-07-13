using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _28
    {
        /// <summary>
        /// Runtime: 116 ms, faster than 16.25% of C# online submissions for Implement strStr().
        /// Memory Usage: 35.9 MB, less than 21.43% of C# online submissions for Implement strStr().
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
