using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1662_Check_If_Two_String_Arrays_are_Equivalent
    {
        /// <summary>
        /// Runtime: 144 ms, faster than 39.29% of C# online submissions for Check If Two String Arrays are Equivalent.
        /// Memory Usage: 39.3 MB, less than 81.63% of C# online submissions for Check If Two String Arrays are Equivalent.
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>

        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var wordFirst = string.Join("", word1);
            var wordSecnod = string.Join("", word2);
            return wordFirst == wordSecnod;
        }
    }
}
