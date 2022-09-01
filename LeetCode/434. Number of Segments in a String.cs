using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _434
    {
        /// <summary>
        /// Runtime: 82 ms, faster than 67.35% of C# online submissions for Number of Segments in a String.
        /// Memory Usage: 34.1 MB, less than 98.64% of C# online submissions for Number of Segments in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountSegments(string s)
        {
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
