using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _96
    {
        /// <summary>
        /// Runtime: 40 ms, faster than 37.25% of C# online submissions for Unique Binary Search Trees.
        /// Memory Usage: 25.1 MB, less than 61.13% of C# online submissions for Unique Binary Search Trees.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees_2(int n)
        {
            long c = 1;
            for (int i = 0; i < n; i++)
            {
                c = c * 2 * (2 * i + 1) / (2 + i);
            }
            return (int)c;
        }
        /// <summary>
        /// Runtime: 29 ms, faster than 70.45% of C# online submissions for Unique Binary Search Trees.
        /// Memory Usage: 26.7 MB, less than 6.48% of C# online submissions for Unique Binary Search Trees.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int NumTrees(int n)
        {
            int[] G = new int[n + 1];

            G[0] = 1;
            G[1] = 1;

            for (int nn = 2; nn <= n; nn++)
            {
                for (int i = 1; i <= nn; i++)
                {
                    G[nn] += G[i - 1] * G[nn - i];
                }
            }
            return G[n];
        }
    }
}
