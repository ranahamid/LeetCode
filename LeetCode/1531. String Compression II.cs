using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1531
    {
        /// <summary>
        /// Runtime 195 ms Beats 100% Memory 37 MB Beats 100%
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int GetLengthOfOptimalCompression(string s, int k)
        {
            var n = s.Length;
            var dp = new int[101, 101];
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = 9999;
                }
            }
            dp[0, 0] = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    int count = 0, delete = 0;
                    for (int l = i; l >= 1; l--)
                    {
                        if (s[l - 1] == s[i - 1])
                            count++;
                        else
                            delete++;
                        if (j - delete >= 0)
                        {
                            var temp = count >= 100 ? 3 : count >= 10 ? 2 : count >= 2 ? 1 : 0;
                            var current = dp[l - 1, j - delete] + temp + 1;
                            dp[i, j] = Math.Min(dp[i, j], current);
                        }
                        if (j > 0)
                            dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - 1]);
                    }
                }
            }
            return dp[n, k];
        }
    }
}
