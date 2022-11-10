using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _867
    {
        /// <summary>
        /// Runtime: 243 ms, faster than 33.42% of C# online submissions for Transpose Matrix.
        /// Memory Usage: 45.9 MB, less than 69.16% of C# online submissions for Transpose Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int[][] Transpose(int[][] matrix)
        {
            var column = matrix[0].Length;
            int[][] result = new int[column][];
            var row = matrix.Length;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                result[i] = new int[row];
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }
            return result;
        }

    }
}
