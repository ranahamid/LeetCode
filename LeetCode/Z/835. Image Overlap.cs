using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _835
    {
        /// <summary>
        /// Runtime 265 ms Beats 25% Memory 41.8 MB Beats 25%
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public List<(int, int)> GetOneValues(int[][] matrix)
        {
            var result = new List<(int, int)>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        result.Add((i, j));
                    }
                }
            }
            return result;
        }
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            var matrix1 = GetOneValues(img1);
            var matrix2 = GetOneValues(img2);
            var max = 0;
            var dic = new Dictionary<(int, int), int>();
            foreach (var x in matrix1)
            {
                foreach (var y in matrix2)
                {
                    var pair = (y.Item1 - x.Item1, y.Item2 - x.Item2);
                    if (dic.ContainsKey(pair))
                    {
                        dic[pair]++;
                    }
                    else
                    {
                        dic[pair] = 1;
                    }
                    max = Math.Max(max, dic[pair]);
                }
            }
            return max;
        }
    }
}
