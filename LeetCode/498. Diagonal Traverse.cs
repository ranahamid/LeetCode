using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _498
    {
        /// <summary>
        /// Runtime 268 ms Beats 69.60% Memory 47.3 MB Beats 95.15%
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public int[] FindDiagonalOrder(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int r = 0, c = 0;
            var answer = new int[m * n];
            for (int position = 0; position < m * n; position++)
            {
                answer[position] = mat[r][c];

                if ((r + c) % 2 == 0)  // The direction is always up when the sum of row & col is even
                {
                    if (c == n - 1) // For last column, go down
                    {
                        r++;
                    }
                    else if (r == 0)  // For first row & non-last columns, go right
                    {
                        c++;
                    }
                    else // For not first row & non-last columns, go up and to the right
                    {
                        r--;
                        c++;
                    }
                }
                else // The direction is always down when the sum of row & col is odd
                {
                    if (r == m - 1)  // For last row, go right
                    {
                        c++;
                    }
                    else if (c == 0)   //  For non-last row & first column, go down
                    {
                        r++;
                    }
                    else  // For non-last row & non-first column, go down and to the left
                    {
                        c--;
                        r++;
                    }
                }
            }
            return answer;
        }
    }
}
