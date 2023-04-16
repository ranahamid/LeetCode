using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2639
    {
        public int[] FindColumnWidth(int[][] grid)
        {
            var row = grid.Length;
            var column = grid[0].Length;
            var result = new int[column];
            for (int i = 0; i < column; i++)
            {
                var max = 0;
                for (int j = 0; j < row; j++)
                {
                    var str = grid[j][i].ToString();
                    max = Math.Max(max, str.Length);
                }
                result[i] = max;
            }
            return result;
        }
    }
}
