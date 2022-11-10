using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1572_Matrix_Diagonal_Sum
    {
        /// <summary>
        /// Runtime: 132 ms, faster than 55.84% of C# online submissions for Matrix Diagonal Sum.
        /// Memory Usage: 39.6 MB, less than 43.12% of C# online submissions for Matrix Diagonal Sum.
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public static int DiagonalSum(int[][] mat)
        {
            int i = 0;
            int j = 0;
            var len = mat.Length;
            var sum = 0;
            while (i < len)
            {
                sum = sum + mat[i][j];
                i++;
                j++;
            }
            i = len - 1;
            j = 0;
            while (i >= 0)
            {
                if (len % 2 == 1 && i == j)
                {

                }
                else
                {
                    sum = sum + mat[i][j];
                }

                i--;
                j++;
            }
            return sum;
        }
    }
}
