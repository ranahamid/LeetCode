using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1329
    {
        public int[][] DiagonalSort(int[][] mat)
        {

            var dic = new Dictionary<int, PriorityQueue<int, int>>();
            for (int row = 0; row < mat.Length; row++)
            {
                for (int column = 0; column < mat[0].Length; column++)
                {
                    var val = row - column;
                    if (!dic.ContainsKey(val))
                    {
                        dic[val] = new PriorityQueue<int, int>();
                    }
                    dic[val].Enqueue(mat[row][column], mat[row][column]);
                }
            }
            for (int row = 0; row < mat.Length; row++)
            {
                for (int column = 0; column < mat[0].Length; column++)
                {
                    var val = row - column;
                    mat[row][column] = dic[val].Dequeue();
                }
            }
            return mat;
        }
    }
}
