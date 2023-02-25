using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1259
    {
        public int NumberOfWays(int numPeople)
        {
            int m = (int)Math.Pow(10, 9) + 7;
            var dp = new int[numPeople / 2 + 1];
            dp[0] = 1;
            for (int i = 1; i <= numPeople / 2; i++)
                for (int j = 0; j < i; j++)
                {
                    dp[i] += (int)((long)dp[j] * dp[i - j - 1] % m);
                    dp[i] %= m;
                }
            return dp[numPeople / 2];
        }
    }
}
