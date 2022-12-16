using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _997
    {
        /// <summary>
        /// Runtime 246 ms Beats 98.77% Memory 53.9 MB Beats 26.54%
        /// </summary>
        /// <param name="n"></param>
        /// <param name="trust"></param>
        /// <returns></returns>
        public int FindJudge(int n, int[][] trust)
        {

            if (trust.Length < n - 1)
            {
                return -1;
            }
            var count = new int[n + 1];
            foreach (var item in trust)
            {
                count[item[0]]--;
                count[item[1]]++;
            }
            for (int i = 1; i <= n; i++)
            {
                if (count[i] == n - 1)
                    return i;
            }
            return -1;
        }
    }
}
