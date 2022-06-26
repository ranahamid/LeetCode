using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1332_Remove_Palindromic_Subsequences
    {

        /// <summary>
        /// Runtime: 74 ms, faster than 73.79% of C# online submissions for Remove Palindromic Subsequences.
        /// Memory Usage: 34.7 MB, less than 47.15% of C# online submissions for Remove Palindromic Subsequences.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RemovePalindromeSub(string s)
        {
            var rev = s.Reverse().ToArray();
            if (s == new string(rev))
            {
                return 1;
            }
            else
                return 2;
        }
    }
}
