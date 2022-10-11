using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1328
    {
        /// <summary>
        /// Runtime 102 ms Beats 69.23% Memory 35.5 MB Beats 61.54%
        /// </summary>
        /// <param name="palindrome"></param>
        /// <returns></returns>
        public string BreakPalindrome(string palindrome)
        {
            if (palindrome.Length == 1)
                return "";
            var sb = new StringBuilder(palindrome);
            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (sb[i] != 'a')
                {
                    sb[i] = 'a';
                    return sb.ToString();
                }
            }
            sb[sb.Length - 1] = 'b';
            return sb.ToString();
        }
    }
}
