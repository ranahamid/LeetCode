using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _823
    {
        /// <summary>
        /// Runtime: 117 ms, faster than 100.00% of C# online submissions for Binary Trees With Factors.
        /// Memory Usage: 39.8 MB, less than 33.33% of C# online submissions for Binary Trees With Factors.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int NumFactoredBinaryTrees(int[] arr)
        {
            var MOD = 1000000007;
            var n = arr.Length;
            Array.Sort(arr);
            var dp = new long[n];
            var index = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                index.Add(arr[i], i);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] % arr[j] == 0)
                    {
                        int k = arr[i] / arr[j];
                        if (index.ContainsKey(k))
                        {
                            dp[i] = (dp[i] + dp[j] * dp[index[k]]) % MOD;
                        }
                    }
                }
            }
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = (sum + dp[i]) % MOD;
            }
            return (int)sum;
        }
    }
}
