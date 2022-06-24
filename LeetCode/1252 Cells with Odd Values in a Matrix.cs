using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1252_Cells_with_Odd_Values_in_a_Matrix
    {
        /// <summary>
        /// Runtime: 102 ms, faster than 85.71% of C# online submissions for Cells with Odd Values in a Matrix.
        /// Memory Usage: 38.2 MB, less than 8.93% of C# online submissions for Cells with Odd Values in a Matrix.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="indices"></param>
        /// <returns></returns>

        public static int OddCells(int m, int n, int[][] indices)
        {
            int[,] array = new int[m, n];
            foreach (var item in indices)
            {
                for (int i = 0; i < m; i++)
                {
                    var val = item[1];
                    array[i, val] = array[i, val] + 1;
                }
                for (int j = 0; j < n; j++)
                {
                    var val = item[0];
                    array[val, j] = array[val, j] + 1;
                }
            }
            var result = 0;
            foreach (var item in array)
            {
                if (item % 2 == 1)
                    result++;
            }
            return result;
        }
    }
}
