using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1758
    {
        /// <summary>
        /// Runtime: 75 ms, faster than 100.00% of C# online submissions for Minimum Changes To Make Alternating Binary String.
        /// Memory Usage: 35.9 MB, less than 17.39% of C# online submissions for Minimum Changes To Make Alternating Binary String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MinOperations(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] - 48) != i % 2)
                    result++;
            }

            return Math.Min(result, s.Length - result);
        }
    }
}
