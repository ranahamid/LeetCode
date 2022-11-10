using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Z
{
    public class _1380__Lucky_Numbers_in_a_Matrix
    {

        /// <summary>
        /// Runtime: 234 ms, faster than 47.62% of C# online submissions for Lucky Numbers in a Matrix.
        /// Memory Usage: 45.5 MB, less than 57.14% of C# online submissions for Lucky Numbers in a Matrix.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static List<int> LuckyNumbers(int[][] matrix)
        {
            var result = new List<int>();
            var row = matrix.Length;
            var column = matrix[0].Length;


            for (int i = 0; i < row; i++)
            {
                var minVal = int.MaxValue;
                var minPoint = 0;
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i][j] < minVal)
                    {
                        minPoint = j;
                        minVal = matrix[i][j];
                    }
                }
                //search max in column
                var allValues = new List<int>();
                for (int k = 0; k < row; k++)
                {
                    allValues.Add(matrix[k][minPoint]);
                }
                var maxVal = allValues.Max();
                if (minVal >= maxVal)
                {
                    result.Add(minVal);
                }
            }

            return result;
        }

    }
}