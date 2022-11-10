using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _598
    {
        /// <summary>
        /// Runtime: 139 ms, faster than 44.83% of C# online submissions for Range Addition II.
        /// Memory Usage: 38.7 MB, less than 44.83% of C# online submissions for Range Addition II.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        public int MaxCount(int m, int n, int[][] ops)
        {
            foreach (var item in ops)
            {
                m = Math.Min(m, item[0]);
                n = Math.Min(n, item[1]);
            }
            return m * n;
        }
    }
}
