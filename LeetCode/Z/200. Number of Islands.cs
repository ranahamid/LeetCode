using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _200
    {
        /// <summary>
        /// Runtime: 153 ms, faster than 72.20% of C# online submissions for Number of Islands.
        /// Memory Usage: 44.7 MB, less than 40.73% of C# online submissions for Number of Islands.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int NumIslands(char[][] grid)
        {
            var totalRows = grid.Length;
            var totalCols = grid[0].Length;
            var count = 0;
            for (int r = 0; r < totalRows; r++)
            {
                for (int c = 0; c < totalCols; c++)
                {
                    if (grid[r][c] == '1')
                    {

                        count++;
                        DFS(grid, totalRows, totalCols, r, c);
                    }
                }
            }
            return count;
        }
        public static void DFS(char[][] grid, int totalRows, int totalCols, int r, int c)
        {
            if (r < 0 || c < 0 || r >= totalRows || c >= totalCols || grid[r][c] == '0')
                return;
            grid[r][c] = '0';
            DFS(grid, totalRows, totalCols, r + 1, c);
            DFS(grid, totalRows, totalCols, r - 1, c);
            DFS(grid, totalRows, totalCols, r, c + 1);
            DFS(grid, totalRows, totalCols, r, c - 1);
        }
    }
}
