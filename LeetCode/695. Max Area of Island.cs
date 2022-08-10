using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _695
    {
        /// <summary>
        /// Runtime: 93 ms, faster than 98.27% of C# online submissions for Max Area of Island.
        /// Memory Usage: 43.1 MB, less than 8.76% of C# online submissions for Max Area of Island.
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public int MaxAreaOfIsland(int[][] grid)
        {
            var totalRows = grid.Length;
            var totalCols = grid[0].Length;
            var seen = new bool[totalRows, totalCols];
            int ans = 0;
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    ans = Math.Max(ans, GetArea(grid, seen, i, j));
                }
            }
            return ans;
        }
        public static int GetArea(int[][] grid, bool[,] seen, int r, int c)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || seen[r, c] == true || grid[r][c] == 0)
                return 0;
            seen[r, c] = true;
            return 1 + GetArea(grid, seen, r + 1, c) + GetArea(grid, seen, r, c + 1) + GetArea(grid, seen, r - 1, c) + GetArea(grid, seen, r, c - 1);
        }
    }
}
