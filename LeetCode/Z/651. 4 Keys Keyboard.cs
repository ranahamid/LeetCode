using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _651
    {
        /// <summary>
        /// Runtime: 1709 ms, faster than 14.29% of C# online submissions for 4 Keys Keyboard.
        /// Memory Usage: 25.3 MB, less than 100.00% of C# online submissions for 4 Keys Keyboard.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int MaxA(int n)
        {
            int max = n;
            int value = 0;
            for (int i = 1; i <= n - 3; i++)
            {
                value = MaxA(i) * (n - i - 1);
                max = Math.Max(max, value);
            }
            return max;
        }
    }
}
