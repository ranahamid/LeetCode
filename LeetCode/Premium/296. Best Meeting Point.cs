using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _296
    {
        /// <summary>
        /// Runtime 169 ms Beats 57.63% Memory 40.4 MB Beats 66.10%
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int MinTotalDistance(int[][] grid)
        {
            var rows = GetRows(grid);
            var cols = GetCols(grid);
            return GetMinimum(rows) + GetMinimum(cols);
        }
        public int GetMinimum(List<int> rows)
        {
            int i = 0;
            int j = rows.Count - 1;
            int counter = 0;
            while (i < j)
            {
                counter += rows[j] - rows[i];
                i++;
                j--;
            }
            return counter;
        }
        public List<int> GetRows(int[][] grid)
        {
            var rows = new List<int>();
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                    if (grid[i][j] == 1)
                        rows.Add(i);
            return rows;
        }

        public List<int> GetCols(int[][] grid)
        {
            var cols = new List<int>();
            for (int i = 0; i < grid[0].Length; i++)
                for (int j = 0; j < grid.Length; j++)
                    if (grid[j][i] == 1)
                        cols.Add(i);
            return cols;
        }
    }
}
