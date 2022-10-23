using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_306
{
    internal class _2373
    {
        /// <summary>
        /// Runtime: 213 ms, faster than 100.00% of C# online submissions for Largest Local Values in a Matrix.
        /// Memory Usage: 45.8 MB, less than 100.00% of C# online submissions for Largest Local Values in a Matrix.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int[][] LargestLocal(int[][] grid)
        {
            var row = grid.Length;
            var column = grid[0].Length;
            var r = row - 2;
            var c = column - 2;
            int[][] result = new int[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    result[i][j] = GetMaxElement(i, j, grid);
                }
            }
            return result;
        }
        public int GetMaxElement(int i, int j, int[][] grid)
        {
            var maxElement = Int32.MinValue;
            for (int r = i; r < i + 3; r++)
            {
                for (int c = j; c < j + 3; c++)
                {
                    if (grid[r][c] > maxElement)
                    {
                        maxElement = grid[r][c];
                    }
                }
            }
            return maxElement;
        }
    }
}
