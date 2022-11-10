using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _48
    {
        /// <summary>
        /// Runtime: 163 ms, faster than 81.27% of C# online submissions for Rotate Image.
        /// Memory Usage: 41.4 MB, less than 32.41% of C# online submissions for Rotate Image.
        /// </summary>
        /// <param name="matrix"></param>
        public void Rotate(int[][] matrix)
        {
            //Transpose
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i + 1; j < matrix[0].Length; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }
            //Reverse
            for (int i = 0; i < matrix.Length; i++)
            {
                int low = 0, high = matrix.Length - 1;
                while (low < high)
                {
                    (matrix[i][low], matrix[i][high]) = (matrix[i][high], matrix[i][low]);
                    low++; high--;
                }
            }
        }
    }
}
