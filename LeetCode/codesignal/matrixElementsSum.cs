using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class matrixElementsSum
    {
        int solution(int[][] matrix)
        {
            var total = 0;
            for (int column = 0; column < matrix[0].Length; column++)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][column] == 0)
                        break;
                    total += matrix[row][column];
                }
            }
            return total;
        }
    }
}
