﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_313
{
    internal class _2428
    {
        public int MaxSum(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            int max = 0;
            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    var currentSum = grid[i][j] + grid[i][j + 1] + grid[i][j + 2] + grid[i + 1][j + 1] +
                        grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2];
                    max = Math.Max(max, currentSum);
                }
            }
            return max;
        }
    }
}
