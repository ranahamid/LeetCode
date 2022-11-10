using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _125_Valid_Palindrome
    {
        /// <summary>
        /// Runtime: 135 ms, faster than 30.82% of C# online submissions for Valid Palindrome.
        /// Memory Usage: 39.7 MB, less than 48.18% of C# online submissions for Valid Palindrome.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public static bool IsPalindrome(string s)
        {
            var chas = s.ToLower().ToCharArray();
            var first = new List<char>();
            for (int i = 0; i < chas.Length; i++)
            {
                if (char.IsLetter(chas[i]) || char.IsDigit(chas[i]))
                {
                    first.Add(chas[i]);
                }
            }
            var carry = first.ToArray();
            for (int i = 0; i < carry.Length; i++)
            {
                if (carry[i] != carry[carry.Length - 1 - i])
                    return false;
            }
            return true;
        }

    }
}
