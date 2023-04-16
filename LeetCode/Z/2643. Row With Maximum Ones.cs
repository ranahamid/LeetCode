using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2643
    {
        public int[] RowAndMaximumOnes(int[][] mat)
        {

            var row = mat.Length;
            var column = mat[0].Length;
            var result = new int[2];

            for (int i = 0; i < row; i++)
            {
                var numOfOnes = 0;
                for (int j = 0; j < column; j++)
                {
                    if (mat[i][j] == 1)
                        numOfOnes++;
                }
                if (numOfOnes > result[1])
                {
                    result[0] = i;
                    result[1] = numOfOnes;

                }
            }
            return result;
        }
    }
}
