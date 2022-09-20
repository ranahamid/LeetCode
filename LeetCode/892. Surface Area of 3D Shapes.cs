using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _892
    {
        /// <summary>
        /// Runtime: 183 ms, faster than 27.27% of C# online submissions for Surface Area of 3D Shapes.
        /// Memory Usage: 38.1 MB, less than 90.91% of C# online submissions for Surface Area of 3D Shapes.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int SurfaceArea(int[][] grid)
        {
            var result = 0;
            var n = grid.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] > 0)
                        result += 4 * grid[i][j] + 2;
                    if (i > 0)
                        result -= 2 * Math.Min(grid[i][j], grid[i - 1][j]);
                    if (j > 0)
                        result -= 2 * Math.Min(grid[i][j], grid[i][j - 1]);
                }
            }
            return result;
        }
    }
}
