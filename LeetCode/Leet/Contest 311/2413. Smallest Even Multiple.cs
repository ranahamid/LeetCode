using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_311
{
    internal class _2413
    {
        /// <summary>
        /// Runtime: 40 ms, faster than 100.00% of C# online submissions for Smallest Even Multiple.
        /// Memory Usage: 25.2 MB, less than 100.00% of C# online submissions for Smallest Even Multiple.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
                return n;
            else
                return n * 2;
        }
    }
}
