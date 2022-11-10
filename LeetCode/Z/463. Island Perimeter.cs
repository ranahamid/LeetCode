using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _463
    {
        /// <summary>
        /// Runtime: 169 ms, faster than 97.51% of C# online submissions for Island Perimeter.
        /// Memory Usage: 50.7 MB, less than 12.45% of C# online submissions for Island Perimeter.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int IslandPerimeter(int[][] grid)
        {
            int up = 0, left = 0, down = 0, right = 0;
            var total = 0;
            var totalRows = grid.Length;
            var totalCols = grid[0].Length;
            for (int r = 0; r < totalRows; r++)
            {
                for (int c = 0; c < totalCols; c++)
                {
                    if (grid[r][c] == 1)
                    {

                        if (r == 0)
                            up = 0;
                        else
                            up = grid[r - 1][c];
                        if (c == 0)
                            left = 0;
                        else
                            left = grid[r][c - 1];

                        if (r == totalRows - 1)
                            down = 0;
                        else
                            down = grid[r + 1][c];
                        if (c == totalCols - 1)
                            right = 0;
                        else
                            right = grid[r][c + 1];
                        total += 4 - (up + left + down + right);
                    }
                }
            }
            return total;
        }
    }
}
