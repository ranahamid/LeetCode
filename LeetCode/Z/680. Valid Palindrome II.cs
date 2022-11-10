using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _680
    {
        /// <summary>
        /// Runtime 133 ms Beats 70.61% Memory 41.6 MB Beats 62.94%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {

                    return IsValidPalindrome(s, i + 1, j) || IsValidPalindrome(s, i, j - 1);
                }
                i++;
                j--;
            }
            return true;
        }
        public bool IsValidPalindrome(string s, int i, int j)
        {

            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }

            return true;
        }
        #region brute
        public bool ValidPalindrome_TLE(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            if (IsValid(sb))
                return true;
            for (int i = 0; i < sb.Length; i++)
            {
                var st = s.Substring(0, i) + s.Substring(i + 1);
                StringBuilder temp = new StringBuilder(st);
                if (IsValid(temp))
                    return true;
            }
            return false;
        }
        public bool IsValid(StringBuilder s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
