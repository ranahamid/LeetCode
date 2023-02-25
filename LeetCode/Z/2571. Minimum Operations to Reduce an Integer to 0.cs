using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2571
    {
        /// <summary>
        /// Runtime: 18 ms, faster than 95.51% of C# online submissions for Minimum Operations to Reduce an Integer to 0.
        /// Memory Usage: 26.6 MB, less than 77.53% of C# online submissions for Minimum Operations to Reduce an Integer to 0.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int MinOperations_1(int n)
        {
            return System.Numerics.BitOperations.PopCount((uint)((n ^ (n * 3))));
        }
    }
}
