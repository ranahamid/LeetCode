using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _883
    {
        /// <summary>
        /// Runtime: 106 ms, faster than 71.43% of C# online submissions for Projection Area of 3D Shapes.
        /// Memory Usage: 38 MB, less than 71.43% of C# online submissions for Projection Area of 3D Shapes.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int ProjectionArea(int[][] grid)
        {
            int counter = 0;

            int N = grid.Length;

            for (int i = 0; i < grid.Length; ++i)
            {
                int maxCol = 0, maxRow = 0;
                for (int j = 0; j < grid.Length; ++j)
                {
                    //From the top, the shadow made by the shape will be 1 square for each non-zero value.
                    if (grid[i][j] > 0)
                        counter++;
                    Console.WriteLine("Counter:" + counter);
                    //From the side, the shadow made by the shape will be the largest value for each row in the grid.
                    maxRow = Math.Max(maxRow, grid[i][j]);
                    //From the front, the shadow made by the shape will be the largest value for each column in the grid.
                    maxCol = Math.Max(maxCol, grid[j][i]);

                }
                Console.WriteLine("maxCol:" + maxCol + ", maxRow:" + maxRow);
                counter += maxCol + maxRow;
            }
            return counter;
        }
        /*
          With the example [[1,2],[3,4]]:

            The shadow from the top will be 4, since there are four non-zero values in the grid;

            The shadow from the side will be 2 + 4, since the maximum value of the first row is 2, and the maximum value of the second row is 4;

            The shadow from the front will be 3 + 4, since the maximum value of the first column is 3, and the maximum value of the second column is 4.
         */
    }
}
