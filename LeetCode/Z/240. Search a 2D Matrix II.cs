using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _240
    {
        /// <summary>
        /// Runtime 257 ms Beats 63.61% Memory 45.2 MB Beats 63.92%
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var row = matrix.Length - 1;
            var col = 0;
            while (row >= 0 && col < matrix[0].Length)
            {
                if (matrix[row][col] > target)
                    row--;
                else if (matrix[row][col] < target)
                    col++;
                else
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Runtime 640 ms Beats 12.34% Memory 45.9 MB Beats 34.49%
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool SearchMatrix_Brute(int[][] matrix, int target)
        {
            foreach (var item in matrix)
                foreach (var num in item)
                    if (num == target)
                        return true;
            return false;
        }
    }
}
