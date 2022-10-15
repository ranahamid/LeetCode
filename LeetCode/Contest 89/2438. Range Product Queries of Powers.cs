using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_89
{
    internal class _2438
    {
        /// <summary>
        /// Runtime 1098 ms Beats 100% Sorry, there are not enough accepted submissions to show data Memory 60.1 MB Beats 100%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int[] ProductQueries(int n, int[][] queries)
        {
            int[] ans = new int[queries.Length];
            long result = 0;
            List<long> listArray = new List<long>();
            List<long> sumArray = new List<long>();
            while (n > 0)
            {
                listArray.Add((long)n % 2);
                n /= 2;
            }
            for (int i = 0; i < listArray.Count(); i++)
            {
                if (listArray[i] == 1)
                {
                    long answer = (long)Math.Pow(2, i);
                    sumArray.Add(answer);
                }
            }
            long MOD = (int)1e9 + 7;
            foreach (var row in queries)
            {
                long sum = 1;
                for (int i = row[0]; i <= row[1]; i++)
                {
                    sum = (sum * sumArray[i] % MOD);
                }
                ans[result] = (int)(sum % MOD);
                result++;
            }
            return ans;
        }
    }
}
