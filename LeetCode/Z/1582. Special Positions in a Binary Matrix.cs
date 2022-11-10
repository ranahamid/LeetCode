using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1582
    {
        /// <summary>
        /// Runtime: 96 ms, faster than 100.00% of C# online submissions for Special Positions in a Binary Matrix.
        /// Memory Usage: 44.3 MB, less than 5.88% of C# online submissions for Special Positions in a Binary Matrix.
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public int NumSpecial(int[][] mat)
        {
            var row = new int[mat.Length];
            var column = new int[mat[0].Length];
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        row[i]++;
                        column[j]++;
                    }
                }
            }
            var counter = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1 && row[i] == 1 && column[j] == 1)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
