using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _2330
    {
        /// <summary>
        /// Runtime: 106 ms, faster than 69.23% of C# online submissions for Valid Palindrome IV.
        /// Memory Usage: 40 MB, less than 46.15% of C# online submissions for Valid Palindrome IV.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool MakePalindrome(string s)
        {
            var len = s.Length;
            var counter = 0;
            var diff = 0;
            while (counter < len)
            {
                if (s[len - 1] != s[counter])
                {
                    diff++;
                }
                counter++;
                len--;
                if (diff > 2)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
