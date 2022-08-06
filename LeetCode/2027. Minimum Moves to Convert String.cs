using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2027
    {
        /// <summary>
        /// Runtime: 126 ms, faster than 18.18% of C# online submissions for Minimum Moves to Convert String.
        /// Memory Usage: 34.8 MB, less than 63.64% of C# online submissions for Minimum Moves to Convert String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinimumMoves(string s)
        {
            var length = s.Length;
            int i = 0;
            var result = 0;
            while (i < length)
            {
                if (s[i] == 'X')
                {
                    i = i + 3;
                    result++;
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}
