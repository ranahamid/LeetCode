using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _73
    {
        /// <summary>
        /// Runtime: 172 ms, faster than 86.15% of C# online submissions for Set Matrix Zeroes.
        /// Memory Usage: 48.5 MB, less than 10.97% of C# online submissions for Set Matrix Zeroes.
        /// </summary>
        /// <param name="matrix"></param>
        public void SetZeroes(int[][] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
