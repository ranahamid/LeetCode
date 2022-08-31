using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1933
    {
        /// <summary>
        /// Runtime: 104 ms, faster than 80.00% of C# online submissions for Check if String Is Decomposable Into Value-Equal Substrings.
       /// Memory Usage: 36.6 MB, less than 60.00% of C# online submissions for Check if String Is Decomposable Into Value-Equal Substrings.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsDecomposable(string s)
        {
            var count = 1;
            var isFoundTwos = false;
            for (int i = 1; i <= s.Length; i++)
            {
                if (i < s.Length && s[i] == s[i - 1])
                    count++;
                else
                {
                    if (count % 3 == 1)
                        return false;
                    else if (count % 3 == 2)
                    {
                        if (isFoundTwos)
                            return false;
                        isFoundTwos = true;
                    }
                    count = 1;
                }
            }
            return isFoundTwos;
        }
    }
}
