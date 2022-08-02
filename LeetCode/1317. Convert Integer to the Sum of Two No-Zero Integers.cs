using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1317
    {
        /// <summary>
        /// Runtime: 163 ms, faster than 38.10% of C# online submissions for Convert Integer to the Sum of Two No-Zero Integers.
        /// Memory Usage: 34.6 MB, less than 61.90% of C# online submissions for Convert Integer to the Sum of Two No-Zero Integers.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] GetNoZeroIntegers(int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = n - 1; j >= 1; j--)
                {
                    if (i + j == n && IsNonZero(i) && IsNonZero(j))
                    {
                        return new int[2] { i, j };
                    }
                }
            }
            return new int[2] { -1, -1 };
        }
        public static bool IsNonZero(int n)
        {
            while (n != 0)
            {
                var rem = n % 10;
                if (rem == 0)
                    return false;
                n = n / 10;
            }
            return true;
        }
    }
}
