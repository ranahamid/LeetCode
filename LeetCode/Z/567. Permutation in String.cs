using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _567
    {
        /// <summary>
        /// Runtime: 1960 ms, faster than 6.69% of C# online submissions for Permutation in String.
        /// Memory Usage: 39.4 MB, less than 24.34% of C# online submissions for Permutation in String.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckInclusion(string s1, string s2)
        {
            s1 = SortedString(s1);
            for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            {

                var temp = s2.Substring(i, s1.Length);
                temp = SortedString(temp);
                if (temp == s1)
                    return true;
            }
            return false;
        }
        public string SortedString(string s1)
        {
            var s1Char = s1.ToCharArray();
            Array.Sort(s1Char);
            s1 = new string(s1Char);
            return s1;
        }
    }
}
