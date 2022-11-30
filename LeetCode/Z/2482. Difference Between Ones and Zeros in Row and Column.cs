using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2482
    {
        /// <summary>
        /// Runtime 1274 ms Beats 6.15% Memory 57 MB Beats 90.77%
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int[][] OnesMinusZeros(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var calc = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                var sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += grid[i][j];
                }
                for (int j = 0; j < n; j++)
                {
                    calc[i, j] = sum;
                }
            }

            for (int j = 0; j < n; j++)
            {
                var sum = 0;
                for (int i = 0; i < m; i++)
                {
                    sum += grid[i][j];
                }
                Console.WriteLine(sum);
                for (int i = 0; i < m; i++)
                {
                    calc[i, j] += sum;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i][j] = calc[i, j] - (m + n - calc[i, j]);
                }
            }
            return grid;
        }
    }
}
