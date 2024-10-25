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
        public int ClimbStairs_2(int n)
        {
            if (n == 1)
                return 1;
            int temp = 0;
            int a = 1, b = 2, c = a + b;
            for (int i = 2; i < n; i++)
            {
                temp = c;
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }


        public int ClimbStairs_3(int n)
        {
            if (n == 1)
                return 1;
            int[] dp = new int[n];
            dp[0] = 1;
            dp[1] = 2;
            for (int i = 2; i < n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n - 1];
        }

    }
}
