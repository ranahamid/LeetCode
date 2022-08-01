using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _62
    {
        /// <summary>
        /// Runtime: 32 ms, faster than 66.11% of C# online submissions for Unique Paths.
        /// Memory Usage: 25.2 MB, less than 71.09% of C# online submissions for Unique Paths.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths(int m, int n)
        {
            int[,] nums = new int[m, n];
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    nums[j, i] = 1;
                }
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    nums[i, j] = nums[i, j - 1] + nums[i - 1, j];
                }
            }
            return nums[m - 1, n - 1];
        }

        /// <summary>
        /// Runtime: 34 ms, faster than 60.13% of C# online submissions for Unique Paths.
        /// Memory Usage: 25.9 MB, less than 29.56% of C# online submissions for Unique Paths.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int UniquePaths_1(int m, int n)
        {
            var nums = new List<List<int>>();
            for (int j = 0; j < m; j++)
            {
                var ns = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    ns.Add(1);
                }
                nums.Add(ns);
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    nums[i][j] = nums[i][j - 1] + nums[i - 1][j];
                }
            }
            return nums[m - 1][n - 1];
        }
    }
}
