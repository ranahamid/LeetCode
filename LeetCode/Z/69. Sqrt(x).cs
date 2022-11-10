using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _69
    {
        /// <summary>
        /// Runtime: 59 ms, faster than 14.10% of C# online submissions for Sqrt(x).
        /// Memory Usage: 24.7 MB, less than 100.00% of C# online submissions for Sqrt(x).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int MySqrt(int x)
        {
            if (x == 0 || x == 1)
                return x;
            long result = 1;
            long i = 1;
            while (result <= x)
            {
                i++;
                result = i * i;

            }
            return (int)i - 1;
        }
    }
}
