using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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
        public bool CheckInclusion(string p, string s)
        {
            var result = new List<int>();
            var pChar = p.ToCharArray();
            Array.Sort(pChar);
            p = new string(pChar);

            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                var subStr = s.Substring(i, p.Length);
                var ar = subStr.ToArray();
                Array.Sort(ar);
                if (p == new String(ar))
                    return true;
            }
            return false;
        }
    }
}
