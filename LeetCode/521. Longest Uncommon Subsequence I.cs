using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _521
    {
        /// <summary>
        /// Runtime: 110 ms, faster than 27.27% of C# online submissions for Longest Uncommon Subsequence I.
        //Memory Usage: 34.8 MB, less than 72.73% of C# online submissions for Longest Uncommon Subsequence I.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int FindLUSlength(string a, string b)
        {
            if (a != b)
                return Math.Max(a.Length, b.Length);
            else return -1;
        }

    }
}
