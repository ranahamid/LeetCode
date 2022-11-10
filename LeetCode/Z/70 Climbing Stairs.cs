using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _70_Climbing_Stairs
    {
        /// <summary>
        /// Runtime: 23 ms, faster than 88.94% of C# online submissions for Climbing Stairs.
        /// Memory Usage: 25.2 MB, less than 67.50% of C# online submissions for Climbing Stairs.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            int[] p = new int[n + 1];
            p[1] = 1;
            p[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                p[i] = p[i - 1] + p[i - 2];
            }
            return p[n];
        }

    }
}
