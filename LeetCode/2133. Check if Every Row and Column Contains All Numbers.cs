using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2133
    {
        /// <summary>
        /// Runtime: 247 ms, faster than 92.00% of C# online submissions for Check if Every Row and Column Contains All Numbers.
        /// Memory Usage: 53 MB, less than 5.00% of C# online submissions for Check if Every Row and Column Contains All Numbers.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public bool CheckValid(int[][] matrix)
        {
            var lenght = matrix.Length;
            for (int i = 0; i < lenght; i++)
            {
                HashSet<int> row = new HashSet<int>();
                HashSet<int> column = new HashSet<int>();
                for (int j = 0; j < lenght; j++)
                {
                    if (row.Contains(matrix[i][j]))
                        return false;
                    if (column.Contains(matrix[j][i]))
                        return false;
                    row.Add(matrix[i][j]);
                    column.Add(matrix[j][i]);
                }
            }
            return true;
        }
    }
}
