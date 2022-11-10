using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _305
    {
        #region TLE
        public IList<int> NumIslands2(int m, int n, int[][] positions)
        {
            var grid = new char[m][];
            var result = new List<int>();
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = new char[n];
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    grid[i][j] = '0';
                }
            }
            foreach (var item in positions)
            {
                grid[item[0]][item[1]] = '1';
                var number = NumIslands(grid);
                result.Add(number);
            }

            return result;
        }
        public static int NumIslands(char[][] temp)
        {
            var totalRows = temp.Length;
            var totalCols = temp[0].Length;
            var grid = new char[totalRows][];
            for (int i = 0; i < temp.Length; i++)
            {
                grid[i] = new char[totalCols];
            }
            for (int i = 0; i < totalRows; i++)
            {
                for (int j = 0; j < totalCols; j++)
                {
                    grid[i][j] = temp[i][j];
                }
            }
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
        #endregion
    }
}
