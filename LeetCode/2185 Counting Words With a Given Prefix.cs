using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2185_Counting_Words_With_a_Given_Prefix
    {
        /// <summary>
        /// Runtime: 189 ms, faster than 5.00% of C# online submissions for Counting Words With a Given Prefix.
        /// Memory Usage: 39.4 MB, less than 59.00% of C# online submissions for Counting Words With a Given Prefix.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="pref"></param>
        /// <returns></returns>
        public static int PrefixCount(string[] words, string pref)
        {
            var result = 0;
            foreach (var item in words)
            {
                if (item.StartsWith(pref))
                    result++;
            }
            return result;
        }


    }
}
