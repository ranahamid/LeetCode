using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1329
    {
        /// <summary>
        /// Runtime: 142 ms, faster than 100.00% of C# online submissions for Sort the Matrix Diagonally.
        /// Memory Usage: 46.6 MB, less than 6.58% of C# online submissions for Sort the Matrix Diagonally.
        /// </summary>
        /// <param name="mat"></param>
        /// <returns></returns>
        public int[][] DiagonalSort(int[][] mat)
        {
            // sort by /
            var dic = new Dictionary<int, PriorityQueue<int, int>>();
            for (int row = 0; row < mat.Length; row++)
            {
                for (int column = 0; column < mat[0].Length; column++)
                {
                    if (!dic.ContainsKey(row - column))
                    {
                        dic[row - column] = new PriorityQueue<int, int>();
                    }
                    dic[row - column].Enqueue(mat[row][column], mat[row][column]);
                }
            }
            for (int row = 0; row < mat.Length; row++)
            {
                for (int column = 0; column < mat[0].Length; column++)
                {
                    mat[row][column] = dic[row - column].Dequeue();
                }
            }
            return mat;
        }
        /// <summary>
        /// Codesignal
        /// sort matrix diagonal  , matrix sort
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        int[][] solution(int[][] a)
        {
            // sort by \
            var dic = new Dictionary<int, PriorityQueue<int, int>>();

            for (int row = 0; row < a.Length; row++)
                for (int column = 0; column < a[0].Length; column++)
                {
                    if (!dic.ContainsKey(row + column))
                        dic[row + column] = new PriorityQueue<int, int>();
                    dic[row + column].Enqueue(a[row][column], -a[row][column]);
                }


            for (int row = 0; row < a.Length; row++)
            {
                for (int column = 0; column < a[0].Length; column++)
                {
                    a[row][column] = dic[row + column].Dequeue();
                }
            }
            return a;
        }

    }
}
