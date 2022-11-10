using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2352
    {
        public int EqualPairs(int[][] grid)
        {
            var len = grid.Length;
            int result = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    int sum = 0;
                    while (sum < len && grid[i][sum] == grid[sum][j])
                    {
                        sum++;
                    }
                    if (len == sum)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
