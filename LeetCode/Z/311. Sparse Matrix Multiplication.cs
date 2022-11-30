using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _311
    {
        public int[][] Multiply(int[][] mat1, int[][] mat2)
        {

            var m = mat1.Length;
            var n = mat1[0].Length;
            var qb = mat2[0].Length;

            var result = new int[m][];
            for (int i = 0; i < m; i++)
                result[i] = new int[qb];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    for (int k = 0; k < qb; k++)
                        result[i][k] += mat1[i][j] * mat2[j][k];
            return result;
        }
    }
}
